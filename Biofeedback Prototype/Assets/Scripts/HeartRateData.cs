using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using brainflow;
using brainflow.math;

public class HeartRateData : MonoBehaviour
{
    private BoardShim board_shim = null;
    private int sampling_rate = 0;
    private int[] ecg_channels;
    private int sampling_interval = 2;
    private double center_frequency = 92.5;
    private int bandwidth = 115;
    private int ring_buffer_size = 400;
    private string serial_port = "COM3";
    private int ecg_channel = 0;

    // Start is called before the first frame update
    void Start()
    {
        try
        {
            //BoardShim.set_log_file("brainflow_log.txt");
            BoardShim.enable_dev_board_logger();

            BrainFlowInputParams input_params = new BrainFlowInputParams();
            int board_id = (int)BoardIds.GANGLION_BOARD;
            input_params.serial_port = serial_port;
            input_params.mac_address = "";
            board_shim = new BoardShim(board_id, input_params);
            board_shim.prepare_session();
            board_shim.start_stream(ring_buffer_size, "file://brainflow_data.csv:w");
            sampling_rate = BoardShim.get_sampling_rate(board_id);
            ecg_channels = BoardShim.get_ecg_channels(board_id); // CHANNELS 1-4
            InvokeRepeating("ProcessData", sampling_interval, sampling_interval);
            Debug.Log("Brainflow streaming was started");
        }
        catch (BrainFlowException e)
        {
            Debug.Log(e);
        }
    }

    void ProcessData()
    {
        if (board_shim == null)
        {
            Debug.Log("NULL board_shim");
            return;
        }
        Debug.Log(board_shim.get_board_data_count());
        double[,] data = board_shim.get_board_data();
        DataFilter.perform_bandpass(data.GetRow(ecg_channels[ecg_channel]), sampling_rate, center_frequency, bandwidth, 2, (int)FilterTypes.BUTTERWORTH, 0.0);
        DataFilter.remove_environmental_noise(data.GetRow(ecg_channels[ecg_channel]), sampling_rate, (int)NoiseTypes.SIXTY);
        Debug.Log("Processed Data");

    }

    // you need to call release_session and ensure that all resources correctly released
    private void OnDestroy()
    {
        if (board_shim != null)
        {
            try
            {
                board_shim.release_session();
            }
            catch (BrainFlowException e)
            {
                Debug.Log(e);
            }
            Debug.Log("Brainflow streaming was stopped");
        }
    }
}