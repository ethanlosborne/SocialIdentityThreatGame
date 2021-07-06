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
    [SerializeField] private BasicInkExample bassy;

    //background image slot for sprite.
    [SerializeField] private Image bg;
    
    //text and text management.
    [SerializeField] private Text textBox;
    [SerializeField] private Text nameBox;
    [SerializeField] private Image continueImage;

    //portrait image slots for character sprites. feel free to move them around.
    [SerializeField] private Image portrait0;
    [SerializeField] private Image portrait1;

    [SerializeField] private Sprite[] bgList;
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
        foreach (char letter in sentence.ToCharArray())
        {
            textBox.text += letter;
            yield return new WaitForSeconds(0.02f);
        }
        toggle_continueImage(true);
        bassy.enable_input();
    }

    //EXTERNAL, INK-LINKED FUNCTIONS
    void set_name(string nom)
    {
        //sets nameText.text to nom.
        nameBox.text = nom;
    }
    void set_background(int bgIndex)
    {
        //This approach externalizes complexity from the ink story.
        //index legend:
        // 0: Office Background 1
        // 1: Office Background 2
        bg.sprite = bgList[bgIndex];
    }
    void set_portrait0(int spriteIndex, int posIndex)
    {
        //spriteIndex corresponds to the index of a sprite in spriteList.
        //posIndex corresponds to a position of the screen where the image will be placed. set to -1 to avoid altering the position.
    }
    void set_portrait1(int spriteIndex, int posIndex)
    {
        //spriteIndex corresponds to the index of a sprite in spriteList.
        //posIndex corresponds to a position of the screen where the image will be placed. set to -1 to avoid altering the position.
    }

    //this function is called in BasicInkExample.
    //this is because it needs a ref to the story.
    public void link_external_functions(Ink.Runtime.Story story)
    {
        story.BindExternalFunction("set_name", (string name) =>
        {
            this.set_name(name);
        });

        story.BindExternalFunction("set_background", (int bgIndex) =>
        {
            this.set_background(bgIndex);
        });

        story.BindExternalFunction("set_portrait0", (int spriteIndex, int posIndex) =>
        {
            this.set_portrait0(spriteIndex, posIndex);
        });

        story.BindExternalFunction("set_portrait1", (int spriteIndex, int posIndex) =>
        {
            this.set_portrait1(spriteIndex, posIndex);
        });
    }

}
