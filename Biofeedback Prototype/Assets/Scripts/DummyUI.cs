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

    [SerializeField] private GameObject dummyImage;

    //functions to be called from within ink script. (note: it must be properly linked in there.)
    //i've linked this two functions there at the start of the script as a template.
    public void dummyImage_to_color(int colorIndex)
    {
        //colorIndex legend
        //0 - red
        //1 - blue

        switch (colorIndex)
        {
            case 0:
                dummyImage.GetComponent<Image>().color = Color.red;
                break;

            case 1:
                dummyImage.GetComponent<Image>().color = Color.blue;
                break;
        }

    }


    //this function is called in BasicInkExample.
    //this is because it needs a ref to the story.
    public void link_external_functions(Ink.Runtime.Story story)
    {
        story.BindExternalFunction("dummy_to_color", (int colorIndex) =>
        {
            this.dummyImage_to_color(colorIndex);
        });
    }

}
