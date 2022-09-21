using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WMSplashManager : MonoBehaviour
{
    [SerializeField] private GameObject instructionsPage;
    [SerializeField] private GameObject endingPage;

    [SerializeField] private WMGUI game;
    [SerializeField] private dataToGSheet dataCollector;


    public void show_ending()
    {
        endingPage.gameObject.SetActive(true);

        //finally, send the collected answers to the google sheet
        dataCollector.Send();
    }

    //quit button
    public void quit_game()
    {
        //called on ending page's button press.
        Application.Quit();
    }
    public void start_game()
    {
        //called on instructions page's button press.
        instructionsPage.gameObject.SetActive(false);
        game.begin();
    }
}
