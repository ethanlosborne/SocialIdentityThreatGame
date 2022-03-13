using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
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
    
    //Note for serial_port:
    //seems to give a different value depending on the dongle.
    //Aaja: COM5. If it is set to COM3, then the game freezes and Unity has to be force closed.
    //I guess we have to switch it depending on who is running.
    private string serial_port = "COM3";
    
    private int ecg_channel = 0;
    private int sample_number = 1;
    private string hr_data_file = "raw_hr_data_test.txt";

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
            ecg_channels = BoardShim.get_ecg_channels(board_id);
            InvokeRepeating("ProcessData", sampling_interval, sampling_interval);
            Debug.Log("Brainflow streaming was started");
        }
        catch (BrainFlowException e)
        {
            Debug.Log(e);
        }
        File.CreateText(hr_data_file);
    }

    void ProcessData()
    {
        if (board_shim == null)
        {
            Debug.Log("NULL board_shim");
            return;
        }
        double[] data = board_shim.get_board_data().GetRow(ecg_channels[ecg_channel]);
        data = DataFilter.perform_bandpass(data, sampling_rate, center_frequency, bandwidth, 2, (int)FilterTypes.BUTTERWORTH, 0.0);
        data = DataFilter.remove_environmental_noise(data, sampling_rate, (int)NoiseTypes.SIXTY);
        using (StreamWriter sw = File.AppendText(hr_data_file))
        {
            sw.WriteLine("Sample " + sample_number.ToString() + "\n" + string.Join(",", data));
            sample_number++;
        }
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
