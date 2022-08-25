using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //main menu controller.
    // -loads the story controller
    //what else does it need to do?

    public void load_story_scene()
    {
        //on start button press
        SceneManager.LoadScene(1);
    }

}
