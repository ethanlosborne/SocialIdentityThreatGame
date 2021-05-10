using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;


public class dataToGSheet : MonoBehaviour
{
    //actually fills out a google form, but that can have an associated google sheet with it.
    //in that way, it does fill out a google sheet using a form as an intermediary.

    //to consider:
    // -some kind of security system for the form to make sure that it only accepts answers acquired in the game. 

    private string[] dataToSend;
    [SerializeField] private string[] entryCodes;

    //to find url:
    //in google form, click send button.
    //copy link from 'send via' tab
    //open in new tab.
    //inspect element
    //search for 'form action'
    //take the value there as the link.
    [SerializeField] private string base_url;

    //to find entry codes: (one for each question)
    //in google form, click three dots on the right, then click get pre-filled link
    //inspect element
    //search for 'entry.'
    //copy the value there. format is: 'entry.somenumber'

    //additionally:
    //make sure the google form doesn't have any settings that 
    //would stop it to be written to.

    public void Send()
    {
        //To add later?
        //because there will be multiple tests, there should also be a field that specifies
        //what test these answers are for. include a test id as some element of dataToSend.
        // - will need to go in and modify the form too.
        
        
        //disable button - one submission per person.
        gameObject.transform.GetChild(8).GetComponent<Button>().interactable = false;

        //here, we'll recuperate the user's input from the text fields as well.
        dataToSend = new string[9]; //or 9?

        //user answers
        //argument to retrieve_input() is the child's position in the hierarchy - if it changes there, it must change here as well.
        dataToSend[0] = retrieve_input(4);
        dataToSend[1] = retrieve_input(5);
        dataToSend[2] = retrieve_input(6);
        dataToSend[3] = retrieve_input(7);

        //correct answers:
        // -left with the results from the current running test for now.
        //can retrieve an int array of final answers if different tests have different answers.
        //e.g. dataToSend[4] through [7] = WMGUI.some static array[0] through [3]
        dataToSend[4] = "13";
        dataToSend[5] = "11";
        dataToSend[6] = "-1";
        dataToSend[7] = "-1";
        
        //lastly, calc the overall accuracy.
        int accuracy = calc_accuracy(dataToSend);
        dataToSend[8] = accuracy + "%";

        //test to make sure the data is correct
        /*
        for (int i = 0; i < 9; i++)
        {
            Debug.Log("dataToSend[" + i + "]: " + dataToSend[i]);
        }
        */    
        StartCoroutine(Post(dataToSend, entryCodes));

    }

    string retrieve_input(int child)
    {
        //disables changing the input fields.
        gameObject.transform.GetChild(child).GetComponent<InputField>().interactable = false;
        return gameObject.transform.GetChild(child).transform.GetChild(2).GetComponent<Text>().text;
    }

    int calc_accuracy(string[] data)
    {
        //hardcoded to assume there are only 4 answer fields. 
        int acc = 0;
        for (int i = 0; i < 4; i++)
        {
            if (data[i] == data[i + 4])
            {
                acc += 25;
            }
        }
        return acc;
    }

    IEnumerator Post(string[] s, string[] e)
    {
        WWWForm form = new WWWForm();

        for (int i = 0; i < s.Length; i++)
        {
            form.AddField(e[i], s[i]);
        }

        UnityWebRequest www = UnityWebRequest.Post(base_url, form);
        yield return www.SendWebRequest();

        //Debug.Log("Post() finished");
    }



    /* Base URL. Here for safe keeping.
     * https://docs.google.com/forms/u/1/d/e/1FAIpQLSefzDxeme6HRZC4tlwoJlvXux43SiJRGKQOccJXcS9zyn8EkA/formResponse
     * 
     * Entry IDs. Here for safe keeping.
     * entry.2073761668
     * entry.1880679911
     * entry.1298641594
     * entry.2108320515
     * entry.1757202364
     * entry.1185371560
     * entry.1788298976
     * entry.1082262959
     * entry.2090790495
     */


}
