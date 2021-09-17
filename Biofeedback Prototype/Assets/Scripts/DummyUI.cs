using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DummyUI : MonoBehaviour
{
    //this is a script to assist the dummy UI canvas.
    //its job is to house functions that can be called from inside the ink story.

    //as proof of concept, i will have it change the colour of the dummy image in the dummy ui canvas.
    //in unity, if you can change the colour, it means you have access to the image, so you could do
    //whatever you want with it. (e.g. change the sprite of the image itself.)

    //After implementation, some notes:
    //pay attention to where you want the function call to actually happen in the story.
    //we show a lot of text at once and ink will run all the calls in each display block
    //as soon as it can. this means that anytime you want to player to see a change in the ui,
    //there must be a stop in ink before the next ui change.
    //(a stop in ink could be something like a choice selection)

    //connections
    [SerializeField] private BasicInkExample bassy; //the story manager
    [SerializeField] private SoundManager SM; //sound manager
    [SerializeField] private FadeManager fader; //sound manager

    //background image slot for sprite.
    [SerializeField] private Image bg;
    
    //text and text management.
    [SerializeField] private Text textBox;
    [SerializeField] private Text nameBox;
    [SerializeField] private Image continueImage;

    //portrait image slots for character sprites. feel free to move them around.
    [SerializeField] private Image[] portraitSlots; //3 slots. left, middle, center. (0, 1, 2)

    [SerializeField] private Sprite[] bgList;
    //all the bgs in the entire game. Legend, by index:
    //0: none
    //1: scene 1 from art drive
    //2: none
    //3: scene 3 from art drive
    //4: scene 4 from art drive
    //5: scene 5 from art drive
    //6: scene 6 from art drive
    //7: scene 7 from art drive
    //8: none
    //9: scene 9 from art drive


    [SerializeField] private Sprite[] spriteList;

    //functions to be called from within ink script. (note: it must be properly linked in there.)
    //i've linked this two functions there at the start of the script as a template. 
      
    void toggle_continueImage(bool state)
    {
        continueImage.gameObject.SetActive(state);
    }

    public void set_textBox(string words)
    {
        StopAllCoroutines();
        toggle_continueImage(false);
        StartCoroutine(typeSentence(words));
    }
    IEnumerator typeSentence(string sentence)
    {
        textBox.text = "";
        string buildMe = "";
        foreach (char letter in sentence.ToCharArray())
        {
            buildMe += letter;
            if (nameBox.text == "")
            {
                textBox.text = buildMe;
            }
            else
            {
                textBox.text = "\"" + buildMe + "\"";
            }
            yield return new WaitForSeconds(0.02f);
        }
        toggle_continueImage(true);
        bassy.enable_input();
    }
    public void play_button_click_sound()
    {
        SM.play_buttonSound();
    }


    //EXTERNAL, INK-LINKED FUNCTIONS
    void stop_music()
    {
        //stops a song from SM.
        SM.stop_playing();
    }
    void play_music(int whichTrack)
    {
        SM.play_loop(whichTrack);
    }
    void play_sound(int whichTrack)
    {
        //plays a song/sound from SM.
        SM.play_once(whichTrack);        
    }
    void set_name(string nom)
    {
        //sets nameText.text to nom.

        if (nom == "")
        {
            nameBox.transform.parent.gameObject.SetActive(false);
            nameBox.text = "";           
        }
        else
        {
            nameBox.text = nom;
            nameBox.transform.parent.gameObject.SetActive(true);
        }
    }
    void set_background(int bgIndex)
    {
        fader.fade_to_black();
        bg.sprite = bgList[bgIndex];
    }
    void set_portrait_slot(int whichSlot)
    {
        //whichSlot legend:
        //0: left
        //1: center
        //2: right

        //not implementing yet because I still don't know how much variations the char images will have.
        //if they have different expressions, then we need to use 99-style indexing (and include another function arg)
        //etc.
        /*
        portraitSlots[whichSlot].GetComponent<Image>().sprite = pLibrary.retrieve_fullp(index);
        portraitSlots[whichSlot].SetActive(true);
        */
    }

    //this function is called in BasicInkExample.
    //this is because it needs a ref to the story.
    public void link_external_functions(Ink.Runtime.Story story)
    {
        //SOUND
        story.BindExternalFunction("stop_music", () =>
        {
            this.stop_music();
        });
        story.BindExternalFunction("play_music", (int whichTrack) =>
        {
            this.play_music(whichTrack);
        });
        story.BindExternalFunction("play_sound", (int whichTrack) =>
        {
            this.play_sound(whichTrack);
        });
        
        //VISUALS
        story.BindExternalFunction("set_name", (string name) =>
        {
            this.set_name(name);
        });
        story.BindExternalFunction("set_background", (int bgIndex) =>
        {
            this.set_background(bgIndex);
        });
        story.BindExternalFunction("set_portrait_slot", (int whichSlot) =>
        {
            this.set_portrait_slot(whichSlot);
        });
    }

}
