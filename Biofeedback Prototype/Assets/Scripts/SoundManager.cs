using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource musicPlayer;
    [SerializeField] private AudioSource soundPlayer;

    //for the heartbeat stuff:
    // -add another audio source to handle that, maybe?

    [SerializeField] private AudioClip buttonClickSound;
    [SerializeField] private AudioClip[] musicArr; 
    [SerializeField] private AudioClip[] soundArr;

    //SPECIFIC MUSIC FUNCTIONS - OUTSIDE INK
    public void play_buttonSound()
    {
        soundPlayer.PlayOneShot(buttonClickSound);
    }


    //GENERAL MUSIC FUNCTIONS - INSIDE INK
    public void play_loop(int whichTrack)
    {
        //plays indicated track from musicArr. looped.

        //first stop if another track was playing.
        stop_playing();

        musicPlayer.clip = musicArr[whichTrack];
        musicPlayer.Play();
    }
    public void play_once(int whichTrack)
    {
        //plays indicated sound from soundArr. not looped.
        soundPlayer.PlayOneShot(soundArr[whichTrack]);
    }
    public void stop_playing()
    {
        //stops musicPlayer.
        musicPlayer.Stop();
    }

}
