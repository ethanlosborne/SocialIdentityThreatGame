using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InkSettings : MonoBehaviour
{
    //here is a class to manage ink settings and allow the player to change them.

    public static bool showingSettings; //stops the player from progressing while the settings is being shown.
    [SerializeField] private GameObject settingsPage;
    [SerializeField] private Button settingsButton;
    private float waitTime = 0.02f;

    public float get_waitTime() { return waitTime; }

    public void set_waitTime(System.Single dummy)
    {
        //waitTime = waitTimeSlider.value;
        waitTime = dummy;
    }

    //display settings button
    public void show_settings()
    {
        settingsButton.interactable = false;
        showingSettings = true;
        settingsPage.SetActive(true);
    }
    public void hide_settings()
    {
        settingsButton.interactable = true;
        showingSettings = false;
        settingsPage.SetActive(false);
    }

    //quit button
    public void quit_game()
    {
        Application.Quit();
    }

}
