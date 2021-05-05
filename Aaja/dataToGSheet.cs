using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class dataToGSheet : MonoBehaviour
{
    //actually fills out a google form, but that can have an associated google sheet with it.
    //in that way, it does fill out a google sheet using a form as an intermediary.

    //to consider:
    // -some kind of security system for the form, or link protection.

    private string[] dataToSend;
    private string[] entryCodes;

    //to find url:
    //in google form, click send button.
    //copy link from 'send via' tab
    //open in new tab.
    //inspect element
    //search for 'form action'
    //take the value there as the link.
    private string base_url;

    //to find entry codes: (one per each question)
    //in google form, click three dots on the right, then click get pre-filled link
    //inspect element
    //search for 'entry.'
    //copy the value there. 'entry.somenumer'

    //make sure the google form doesn't have any settings that 
    //would stop it to be written to.


    void Awake()
    {        
        //fill dataToSend with whatever you want. for testing purposes.
        dataToSend = new string[3];
        dataToSend[0] = "some value 1";
        dataToSend[1] = "some value 2";
        dataToSend[2] = "some value 3";

        entryCodes = new string[3];
        entryCodes[0] = "entry.864812598";
        entryCodes[1] = "entry.1925070309";
        entryCodes[2] = "entry.1006453112";

        base_url = "https://docs.google.com/forms/u/1/d/e/1FAIpQLScm7NjKNjEvVbxNPnqaH3aVej3vlcT0vqCSkz4O9QbNBZa4EA/formResponse";

        //Debug.Log("Awake done");
    }
    
    public void Send()
    {
        //called on send data button press.
        StartCoroutine(Post(dataToSend, entryCodes));
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

}
