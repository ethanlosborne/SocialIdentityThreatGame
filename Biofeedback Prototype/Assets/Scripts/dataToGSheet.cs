using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;


public class dataToGSheet : MonoBehaviour
{
    //data is finally sent by the exit button on the wm splash manager

    //actually fills out a google form, but that can have an associated google sheet with it.
    //in that way, it fills out a google sheet using a form as an intermediary.

    private string[] workingData; //array of data to facilitate manipulation.
    private string[] dataToSend; //array of strings that will be used to collect data.

    int data_array_length = 9 + 1 + 12 + 10;

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
        dataToSend = new string[data_array_length];
        for (int i = 0; i < dataToSend.Length; i++)
        {
            dataToSend[i] = "default " + i;
        }

        med1ans = new string[4] { "15", "5", "9", "8" };
        med2ans = new string[4] { "8", "5", "8", "17" };
        med3ans = new string[4] { "1", "11", "1", "6" };
        hard1ans = new string[4] { "99", "64", "19", "14" };
        hard2ans = new string[4] { "58", "18", "17", "17" };
        hard3ans = new string[4] { "42", "23", "45", "78" };
        answers = new string[][] { med1ans, med2ans, med3ans, hard1ans, hard2ans, hard3ans };
    }

    public void calculate_midstep()
    {
        //called everytime the player hits the next button at the end of each wm test.
        //here, we'll recuperate the user's input from the text fields as well.
        workingData = new string[8];

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
            workingData[i] = answers[WMGUI.count - 1][i - 4];
        }

        //Debug.Log("calc midstep called. accuracy = " + calc_accuracy(workingData));
        //lastly, calc the accuracy.
        dataToSend[WMGUI.count - 1] = calc_accuracy(workingData).ToString();
    }
    string retrieve_input(int child)
    {
        //disables changing the input fields.
        GameObject obj = gameObject.transform.GetChild(child).gameObject;
        obj.GetComponent<InputField>().interactable = false;
        return obj.transform.GetChild(2).GetComponent<Text>().text;
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

        gameObject.SetActive(true);

        //data:
        // 0, 1, 2, 3, 4, 5: accuracy for each of the 6 wm tests
        // 7, 8, 9: avg accuracies for wm tests of each type
        // 10: watched/not watched surveys
        // 11, 12, 13, 14, 16, 17, 18, 19, 20, 21, 22, 23: likert scale answers
        // 24, 25, 26, 27, 28, 29, 30, 31, 32, 33: freeflow story responses

        //calc average accuracies (7, 8, 9)
        //dummy:
        dataToSend[6] = "0";
        dataToSend[7] = "0";
        dataToSend[8] = "0";

        //Debug.Log("data to g sheet Send() called");
        string surveyResultsStr = "|";
        for (int i = 0; i < DummyUI.surveyData.Length; i++)
        {
            if (DummyUI.surveyData[i] == true)
            {
                surveyResultsStr += "w|";
            }
            else
            {
                surveyResultsStr += "nw|";
            }
        }
        dataToSend[9] = surveyResultsStr;

        for (int i = 0; i < ScaleQuestions.answers.Count; i++)
        {
            //Debug.Log("likert answers " + i + " = " + ScaleQuestions.answers[i]);
            switch (ScaleQuestions.answers[i])
            {
                case 0:
                    dataToSend[10 + i] = "Strongly Disagree";
                    break;
                case 1:
                    dataToSend[10 + i] = "Disgree";
                    break;
                case 2:
                    dataToSend[10 + i] = "Somewhat Disagree";
                    break;
                case 3:
                    dataToSend[10 + i] = "Neither Agree nor Disagree";
                    break;
                case 4:
                    dataToSend[10 + i] = "Somewhat Agree";
                    break;
                case 5:
                    dataToSend[10 + i] = "Agree";
                    break;
                case 6:
                    dataToSend[10 + i] = "Strongly Agree";
                    break;
                default:
                    dataToSend[10 + i] = "error";
                    break;
            }
        }

        for (int i = 0; i < DummyUI.playerResponses.Count; i++)
        {
            //Debug.Log("freeflow responses " + i + " = " + DummyUI.playerResponses[i]);
            dataToSend[22 + i] = DummyUI.playerResponses[i];
        }

        gameObject.transform.GetChild(8).GetComponent<Button>().interactable = false;
        StartCoroutine(Post(dataToSend, entryCodes));
    }
    IEnumerator Post(string[] s, string[] e)
    {
        //length of e = length of s + 1
        // (s is the answers, e is the entry codes)

        //let's check all the post answers
        for (int i = 0; i < s.Length; i++)
        {
            Debug.Log("data to send " + i + " = " + s[i]);
        }

        Debug.Log("sending post");
        WWWForm form = new WWWForm();

        for (int i = 0; i < s.Length; i++)
        {
            Debug.Log("form add field. i = " + i);
            form.AddField(e[i], s[i]);
        }

        UnityWebRequest www = UnityWebRequest.Post(base_url, form);
        yield return www.SendWebRequest();

        Debug.Log("Post() finished");
    }

    /* Base URL. Here for safe keeping.
     * https://docs.google.com/forms/u/1/d/e/1FAIpQLSefzDxeme6HRZC4tlwoJlvXux43SiJRGKQOccJXcS9zyn8EkA/formResponse
     */
    private string[] entryCodes = new string[32]
    {
        "entry.2073761668",
        "entry.1880679911",
        "entry.1298641594",
        "entry.2108320515",
        "entry.1757202364",
        "entry.1185371560",
        "entry.1788298976",
        "entry.1082262959",
        "entry.2090790495",
        "entry.444355738",
        "entry.1180650872",
        "entry.173892856",
        "entry.888025831",
        "entry.467974937",
        "entry.125406472",
        "entry.2060611963",
        "entry.1431374527",
        "entry.542417653",
        "entry.265181994",
        "entry.124050161",
        "entry.1410974371",
        "entry.214274447",
        "entry.1266217193",
        "entry.553423930",
        "entry.1245370276",
        "entry.1180396685",
        "entry.2143265731",
        "entry.1333016223",
        "entry.1236652907",
        "entry.320139531",
        "entry.694523514",
        "entry.1056612515"
    };

}
