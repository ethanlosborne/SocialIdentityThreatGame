using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class HeartRateManager : MonoBehaviour
{
    public Text hrText;
    public string heartRatePacket;
    public GameObject low_Heart;
    public GameObject low_Medium_Heart;
    public GameObject moderate_Heart;
    public GameObject high_Heart;
    public GameObject maximum_Heart;


    void Awake()
    {
        hrText = this.gameObject.GetComponent<Text>();
        heartRatePacket = this.gameObject.GetComponent<UDPReceive>().lastReceivedUDPPacket;
    }
    
    // Update is called once per frame
    void Update()
    {
        heartRatePacket = this.gameObject.GetComponent<UDPReceive>().lastReceivedUDPPacket;
        heartRatePacket = heartRatePacket.Trim();
        hrText.text = heartRatePacket;
        int integer_heart_rate = int.Parse(heartRatePacket);
        if (integer_heart_rate > 60 && integer_heart_rate < 80)
        {
            UnityEngine.Debug.Log("Low");
            low_Heart.SetActive(true);
            low_Medium_Heart.SetActive(false);
            moderate_Heart.SetActive(false);
            high_Heart.SetActive(false);
            maximum_Heart.SetActive(false);
        } else if (integer_heart_rate >= 80 && integer_heart_rate < 100)
        {
            UnityEngine.Debug.Log("low Medium");
            low_Heart.SetActive(false);
            low_Medium_Heart.SetActive(true);
            moderate_Heart.SetActive(false);
            high_Heart.SetActive(false);
            maximum_Heart.SetActive(false);
        } else if (integer_heart_rate >= 100 && integer_heart_rate < 120)
        {
            UnityEngine.Debug.Log("moderate");
            low_Heart.SetActive(false);
            low_Medium_Heart.SetActive(false);
            moderate_Heart.SetActive(true);
            high_Heart.SetActive(false);
            maximum_Heart.SetActive(false);
        } else if (integer_heart_rate >= 120 && integer_heart_rate < 140)
        {
            UnityEngine.Debug.Log("high");
            low_Heart.SetActive(false);
            low_Medium_Heart.SetActive(false);
            moderate_Heart.SetActive(false);
            high_Heart.SetActive(true);
            maximum_Heart.SetActive(false);
        } else if (integer_heart_rate >= 140)
        {
            UnityEngine.Debug.Log("max");
            low_Heart.SetActive(false);
            low_Medium_Heart.SetActive(false);
            moderate_Heart.SetActive(false);
            high_Heart.SetActive(false);
            maximum_Heart.SetActive(true);
        }
    }

}
