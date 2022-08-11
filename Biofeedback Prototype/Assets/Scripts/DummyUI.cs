using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class DummyUI : MonoBehaviour
{
    //this is a script to assist the dummy UI canvas.
    //its job is to house functions that can be called from inside the ink story.

    //as proof of concept, i will have it change the colour of the dummy image in the dummy ui canvas.
    //in unity, if you can change the colour, it means you have access to the image, so you could do
    //whatever you want with it. (e.g. change the sprite of the image itself.)

    //connections
    [SerializeField] private InkSettings settingsManager; //manages ink story settings.
    [SerializeField] private BasicInkExample bassy; //the story manager
    [SerializeField] private SoundManager SM; //sound manager
    [SerializeField] private FadeManager fader; //fade manager

    [SerializeField] private VideoPlayer vPlayer; //video player
    public bool video_progressBlock = false;

    //survey data collection
    public static bool[] surveyData = new bool[5] { false, false, false, false, false };
    //legend:
    // -jake maxwell
    // -paola ortiz
    // -connor mcdermott
    // -zhang wei
    // -logan stiles

    //background image slot for sprite.
    [SerializeField] private Image bg;
    
    //text and text management.
    [SerializeField] private Text textBox;
    [SerializeField] private Text nameBox;
    [SerializeField] private Image continueImage;

    //portrait image slots for character sprites. feel free to move them around.
    [SerializeField] private Image portraitSlot; //a single slot.

    [SerializeField] private Sprite[] bgList;
    [SerializeField] private Image whiteEngineersBgAddon;
    //all the bgs in the entire game. Legend, by index:
    //0: email
    //1: proom email
    //2: scene1
    //3: scene3
    //4: scene4
    //5: scene5
    //6: room1016
    //7: scene7
    //8: scene9
    //9: doorwayopen_rm18
    //10: room1018
    //11: white engineers

    [SerializeField] private Sprite[] portraitList;
    //all the portraits in the  entire game. Legend, by index: (0-8)
    //0: asian engineer (Zhang Wei)
    //1: black security
    //2: black receptionist
    //3: hispanic security
    //4: hispanic marketing (Paola Ortiz)
    //5: white cybersecurity (Logan Stiles)
    //6: white engineer (Jake Maxwell)
    //7: white financial (Connor McDermott)
    //8: white janitor

    void Start()
    {
        playerResponses = new List<string>();
    }
    void Update()
    {

        if (video_progressBlock == true)
        {
            vPlayer.loopPointReached += stop_vidPlayer;
        }
    }
    void stop_vidPlayer(UnityEngine.Video.VideoPlayer vp)
    {      
        video_progressBlock = false;
        toggle_continueImage(true);
        vPlayer.gameObject.SetActive(false);
    }
    

    public void click_continueArrow()
    {
        if (InkSettings.showingSettings == false)
        {
            toggle_continueImage(false);
            bassy.RefreshView();
        }
        
    }
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
        if (settingsManager.get_waitTime() > 0f)
        {
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
                yield return new WaitForSeconds(settingsManager.get_waitTime());
            }
        }
        else
        {
            textBox.text = "\"" + sentence + "\"";
        }
        

        if (video_progressBlock == false) toggle_continueImage(true);
        
        //Debug.Log("finished displaying line. buildMe = " + buildMe);
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
        //fader.fade_to_black(1f);
        if (bgIndex == 11)
        {
            whiteEngineersBgAddon.gameObject.SetActive(true);
            return;
        }
        else
        {
            whiteEngineersBgAddon.gameObject.SetActive(false);
        }
        bg.sprite = bgList[bgIndex];
        //StartCoroutine(set_background_helper(bgIndex));
    }
    IEnumerator set_background_helper(int bgIndex)
    {
        yield return new WaitForSeconds(1f);
        bg.sprite = bgList[bgIndex];
    }

    void set_portrait_slot(int whichSlot)
    {
        //we have only one protrait slot. we show only one character at a time.
        //accepts indices from -1 to 5.

        if (whichSlot == -1)
        {
            portraitSlot.gameObject.SetActive(false);
        }
        else
        {
            portraitSlot.sprite = portraitList[whichSlot];
            portraitSlot.gameObject.SetActive(true);
        }

    }
    void start_vPlayer()
    {
        Debug.Log("video started");
        video_progressBlock = true;
        vPlayer.Play();
    }

    //player input data; set during runtime.
    private string playerName;
    private string playerCollege;
    private List<string> playerResponses;
    [SerializeField] private GameObject nameCollegeInputObj;
    [SerializeField] private InputField nameField;
    [SerializeField] private InputField collegeField;

    [SerializeField] private GameObject responseObj;
    [SerializeField] private InputField responseField;


    void show_name_college()
    {
        nameCollegeInputObj.SetActive(true);
        video_progressBlock = true;
    }
    public void collect_name_college_input()
    {
        //called on input button press.
        //read the player's name and college text.

        playerName = nameField.text;
        playerCollege = collegeField.text;

        bassy.story.variablesState["name"] = playerName;
        bassy.story.variablesState["college"] = playerCollege;

        //hide the input fields and allow story progression.
        nameCollegeInputObj.SetActive(false);
        video_progressBlock = false;
        bassy.RefreshView();
    }
    public void show_response_field()
    {
        responseObj.SetActive(true);
        video_progressBlock = true;
    }
    public void collect_response()
    {
        //reads the response from the input field and adds it to the response list.

        string response = responseField.text;
        responseField.text = "";
        playerResponses.Add(response);

        responseObj.SetActive(false);
        video_progressBlock = false;
        bassy.RefreshView();
    }


    void record_surveys_watched(int which)
    {
        //used to keep track of what surveys were watched.
        //goes and updates the value in a static array of bools 
        //in dataToGSheet.

        surveyData[which] = true;
        Debug.Log("record surveys watched updated, yo!");
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
        story.BindExternalFunction("play_video", () =>
        {
            this.start_vPlayer();
        });

        //DATA COLLECTION
        story.BindExternalFunction("record_surveys_watched", (int which) =>
        {
            this.record_surveys_watched(which);
        });
        story.BindExternalFunction("show_name_college", () =>
        {
            this.show_name_college();
        });
        story.BindExternalFunction("show_response_field", () =>
        {
            this.show_response_field();
        });
    }

}
