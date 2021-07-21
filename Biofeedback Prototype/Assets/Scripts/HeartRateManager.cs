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
    private int integer_heart_rate;
    private int updateCount = 0;
    private int shouldIncrement = 0;


    void Awake()
    {
        hrText = this.gameObject.GetComponent<Text>();
        var heartRatePacket = UnityEngine.Random.Range(60, 140);
        integer_heart_rate = heartRatePacket;
    }
    
    // Update is called once per frame
    void Update()
    {
        updateCount++;
        shouldIncrement++;
        var heartRatePacket = UnityEngine.Random.Range(60, 140);
        if (shouldIncrement >= 150)
        {
            shouldIncrement = 0;
            integer_heart_rate++;
        }
        if (updateCount >= 500)
        {
            updateCount = 0;
            integer_heart_rate = heartRatePacket;
        }
        hrText.text = integer_heart_rate.ToString();
        if (integer_heart_rate > 60 && integer_heart_rate < 80)
        {
            low_Heart.SetActive(true);
            low_Medium_Heart.SetActive(false);
            moderate_Heart.SetActive(false);
            high_Heart.SetActive(false);
            maximum_Heart.SetActive(false);
        } else if (integer_heart_rate >= 80 && integer_heart_rate < 100)
        {
            low_Heart.SetActive(false);
            low_Medium_Heart.SetActive(true);
            moderate_Heart.SetActive(false);
            high_Heart.SetActive(false);
            maximum_Heart.SetActive(false);
        } else if (integer_heart_rate >= 100 && integer_heart_rate < 120)
        {
            low_Heart.SetActive(false);
            low_Medium_Heart.SetActive(false);
            moderate_Heart.SetActive(true);
            high_Heart.SetActive(false);
            maximum_Heart.SetActive(false);
        } else if (integer_heart_rate >= 120 && integer_heart_rate < 140)
        {
            low_Heart.SetActive(false);
            low_Medium_Heart.SetActive(false);
            moderate_Heart.SetActive(false);
            high_Heart.SetActive(true);
            maximum_Heart.SetActive(false);
        } else if (integer_heart_rate >= 140)
        {
            low_Heart.SetActive(false);
            low_Medium_Heart.SetActive(false);
            moderate_Heart.SetActive(false);
            high_Heart.SetActive(false);
            maximum_Heart.SetActive(true);
        }
    }

}
