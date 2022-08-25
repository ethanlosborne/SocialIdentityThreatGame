using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class HeartRateManager : MonoBehaviour
{
    [SerializeField] private Text hrText; //change text according to heartrate
    [SerializeField] private GameObject pointer; //change positin according to heartrate
    [SerializeField] private Image fillBg; //change the colour according to heartrate


    private int integer_heart_rate = -1;
    private int updateCount = 0;
    private int shouldIncrement = 0;

    void Awake()
    {
        int heartRatePacket = UnityEngine.Random.Range(60, 140);
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
        set_gauge(Math.Min(integer_heart_rate, 150));
    }
    void set_gauge(int hr)
    {
        //move the pointer along the gauge
        //left (90 degrees) position: -371, 177
        //mid (180 degrees) position: -338, 143.3
        //right (270 degrees) position: -305, 177

        //x transform coord = 11x/25 - 371
        //y transform coord = 34x^2/5625 - 68x/75 + 177
        //rotation = 6x / 5 + 90

        //set colour: (r,g,b)
        // green: lower
        // red: higher
        float greenAmount = 0f;
        float redAmount = 0f;
        
        if ( hr > 75)
        {
            //greenAmount = 3.4f * (hr - 75);
            //redAmount = 255f - (3.4f * (hr - 75));

            redAmount = 3.4f * (hr - 75);
            greenAmount = 255f - (3.4f * (hr - 75));
        }
        else
        {
            //redAmount = 255f;
            //greenAmount = 3.4f * hr;

            greenAmount = 255f;
            redAmount = 3.4f * hr;
        }

        fillBg.color = new Color( redAmount / 255f, greenAmount / 255f, 0f );

        //set pointer:
        float xCoord = (11f * hr / 25f) - 371f;
        float yCoord = (32f * hr * hr / 5625f) - (68f * hr / 75f) + 177f;
        float rotation = (6f * hr / 50) + 90f;

        Vector3 newPos = new Vector3(xCoord, yCoord, 0);
        pointer.transform.localPosition = newPos;
        pointer.transform.rotation = Quaternion.Euler(0, 0, rotation);
    }

}
