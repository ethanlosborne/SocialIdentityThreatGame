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

    private string[] workingData; //array of data to facilitate manipulation.
    private string[] dataToSend; //array of strings that will be used to collect data.
    [SerializeField] private string[] entryCodes;

    //data collection
    private double medAvg;
    private double hardAvg;

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

    void Awake()
    {       
        dataToSend = new string[9];
        for (int i = 0; i < dataToSend.Length; i++)
        {
            dataToSend[i] = "data to send " + i;
        }

        med1ans = new string[4] { "15", "5", "9", "8" };
        med2ans = new string[4] { "8", "5", "8", "17" };
        med3ans = new string[4] { "1", "11", "1", "6" };
        hard1ans = new string[4] { "99", "64", "19", "14" };
        hard2ans = new string[4] { "58", "18", "17", "17" };
        hard3ans = new string[4] { "42", "23", "45", "78" };
        answers = new string[][] { med1ans, med2ans, med3ans, hard1ans, hard2ans, hard3ans };
    }
    //answer arrays  
    string[] med1ans;
    string[] med2ans;
    string[] med3ans;
    string[] hard1ans;
    string[] hard2ans;
    string[] hard3ans;
    string[][] answers;

    public void Send()
    {
        //testing with dummy data
        //StartCoroutine(Post(dataToSend, entryCodes)); return;

        //here, we'll recuperate the user's input from the text fields as well.
        workingData = new string[9]; //or 9?

        //user answers
        //argument to retrieve_input() is the child's position in the hierarchy - if it changes there, it must change here as well.
        workingData[0] = retrieve_input(4);
        workingData[1] = retrieve_input(5);
        workingData[2] = retrieve_input(6);
        workingData[3] = retrieve_input(7);

        //correct answers:
        // -left with the results from the current running test for now.
        //can retrieve an int array of final answers if different tests have different answers.
        //e.g. dataToSend[4] through [7] = WMGUI.some static array[0] through [3]
        for (int i = 4; i < 8; i++)
        {
            workingData[i] = answers[WMGUI.count-1][i-4];
        }

        //lastly, calc the accuracy.
        dataToSend[WMGUI.count - 1] = calc_accuracy(workingData).ToString();

        

        if (WMGUI.count == 6)
        {
            //lock form and submit. we're done here.
            //test to make sure the data is correct
            /*
            for (int i = 0; i < 9; i++)
            {
                Debug.Log("dataToSend[" + i + "]: " + dataToSend[i]);
            }
            */
            
            gameObject.transform.GetChild(8).GetComponent<Button>().interactable = false;
            StartCoroutine(Post(dataToSend, entryCodes));
        }
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
 
        if ( WMGUI.count < 4)
        {
            medAvg += (double)acc;
            if (WMGUI.count == 3)
            {
                medAvg = medAvg / 3;
                dataToSend[6] = medAvg.ToString();
            }
        }
        else
        {
            hardAvg += (double)acc;
            if (WMGUI.count == 6)
            {
                hardAvg = hardAvg / 3;
                dataToSend[7] = hardAvg.ToString();


                dataToSend[8] = ((medAvg + hardAvg) / 2).ToString();
            }
        }
        return acc;
    }

    IEnumerator Post(string[] s, string[] e)
    {
        Debug.Log("sending post");
        WWWForm form = new WWWForm();

        for (int i = 0; i < s.Length; i++)
        {
            form.AddField(e[i], s[i]+ "%");
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
