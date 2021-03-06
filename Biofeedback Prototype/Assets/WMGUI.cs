using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class WMGUI : MonoBehaviour
{
    [SerializeField] private WMSplashManager splash;

    [SerializeField] private Text testCounterLabel;
    [SerializeField] private Text nextButtonText;

    public Text Box1;
    public Text Box2;
    public Text Box3;
    public Text Box4;
    public InputField Answer1;
    public InputField Answer2;
    public InputField Answer3;
    public InputField Answer4;  
    public GameObject wMCanvas;
    public GameObject dataCanvas;

    public static int count;
    public void begin()
    {
        StartCoroutine(WMCoroutineMed1());        
    }
    // Handles switching of coroutines on button click
    public void next_test()
    {
        if (count == 5)
        {
            nextButtonText.text = "Submit";
        }       

        CoroutineSwitcher();       
    }

    public void CoroutineSwitcher()
    {
        wMCanvas.SetActive(true);
        ClearInputText();
        dataCanvas.SetActive(false);
        
        if ( count + 1 < 7 ) testCounterLabel.text = "Test " + (count + 1).ToString() + " / 6";

        switch (count)
        {
            case 1:
                StartCoroutine(WMCoroutineMed2());
                break;
            case 2:
                StartCoroutine(WMCoroutineMed3());               
                break;
            case 3:
                StartCoroutine(WMCoroutineHard1());
                break;
            case 4:
                StartCoroutine(WMCoroutineHard2());
                break;
            case 5:
                StartCoroutine(WMCoroutineHard3());
                break;
            default:
                //Debug.Log("Default case");
                //Application.Quit();
                splash.show_ending();
                break;
        }
    }

    void update_boxes(string b1, string b2, string b3, string b4)
    {
        Box1.text = b1;
        Box2.text = b2;
        Box3.text = b3;
        Box4.text = b4;
    }


    IEnumerator WMCoroutineMed1()
    {
        update_boxes("7", "4", "5", "3");

        yield return new WaitForSeconds(6.5f);

        update_boxes("", "", "+1", "");

        yield return new WaitForSeconds(3.0f);

        update_boxes("", "+1", "", "");

        yield return new WaitForSeconds(3.0f);

        update_boxes("+8", "", "", "");

        yield return new WaitForSeconds(3.0f);

        update_boxes("", "", "", "+5");

        yield return new WaitForSeconds(3.0f);

        update_boxes("", "", "+3", "");

        yield return new WaitForSeconds(3.0f);

        update_boxes("", "", "", "");

        yield return new WaitForSeconds(3.0f);

        accept_data();
        count ++;        
    }
    IEnumerator WMCoroutineMed2()
    {
        update_boxes("7", "7", "2", "9");

        yield return new WaitForSeconds(6.5f);

        update_boxes("", "", "+7", "");

        yield return new WaitForSeconds(3.0f);

        update_boxes("", "", "", "+8");

        yield return new WaitForSeconds(3.0f);

        update_boxes("+1", "", "", "");

        yield return new WaitForSeconds(3.0f);

        update_boxes("", "", "-1", "");

        yield return new WaitForSeconds(3.0f);

        update_boxes("", "-2", "", "");

        yield return new WaitForSeconds(3.0f);

        update_boxes("", "", "", "");

        yield return new WaitForSeconds(3.0f);

        accept_data();
        count++;
    }
    IEnumerator WMCoroutineMed3()
    {
        update_boxes("3", "1", "2", "8");

        yield return new WaitForSeconds(6.5f);

        update_boxes("", "", "", "-2");

        yield return new WaitForSeconds(3.0f);

        update_boxes("-2", "", "", "");

        yield return new WaitForSeconds(3.0f);

        update_boxes("", "+3", "", "");

        yield return new WaitForSeconds(3.0f);

        update_boxes("", "+7", "", "");

        yield return new WaitForSeconds(3.0f);

        update_boxes("", "", "-1", "");

        yield return new WaitForSeconds(3.0f);

        update_boxes("", "", "", "");

        yield return new WaitForSeconds(3.0f);

        accept_data();
        count++;
    }
    IEnumerator WMCoroutineHard1()
    {
        update_boxes("3", "3", "8", "2");

        yield return new WaitForSeconds(6.5f);

        update_boxes("+86", "", "", "");

        yield return new WaitForSeconds(3.0f);

        update_boxes("+10", "", "", "");

        yield return new WaitForSeconds(3.0f);

        update_boxes("", "", "", "+12");

        yield return new WaitForSeconds(3.0f);

        update_boxes("", "", "+11", "");

        yield return new WaitForSeconds(3.0f);

        update_boxes("", "+61", "", "");

        yield return new WaitForSeconds(3.0f);

        update_boxes("", "", "", "");

        yield return new WaitForSeconds(3.0f);

        accept_data();
        count++;
    }
    IEnumerator WMCoroutineHard2()
    {
        update_boxes("6", "3", "6", "4");

        yield return new WaitForSeconds(6.5f);

        update_boxes("+42", "", "", "");

        yield return new WaitForSeconds(3.0f);

        update_boxes("", "+15", "", "");

        yield return new WaitForSeconds(3.0f);

        update_boxes("", "", "+11", "");

        yield return new WaitForSeconds(3.0f);

        update_boxes("+10", "", "", "");

        yield return new WaitForSeconds(3.0f);

        update_boxes("", "", "", "+13");

        yield return new WaitForSeconds(3.0f);

        update_boxes("", "", "", "");

        yield return new WaitForSeconds(3.0f);

        accept_data();
        count++;
    }
    IEnumerator WMCoroutineHard3()
    {
        update_boxes("1", "2", "3", "1");

        yield return new WaitForSeconds(6.5f);

        update_boxes("", "", "", "+13");

        yield return new WaitForSeconds(3.0f);

        update_boxes("", "+21", "", "");

        yield return new WaitForSeconds(3.0f);

        update_boxes("", "", "+42", "");

        yield return new WaitForSeconds(3.0f);

        update_boxes("+41", "", "", "");

        yield return new WaitForSeconds(3.0f);

        update_boxes("", "", "", "+64");

        yield return new WaitForSeconds(3.0f);

        update_boxes("", "", "", "");

        yield return new WaitForSeconds(3.0f);

        accept_data();
        count++;
    }

    //clears text areas after button click
    void ClearInputText() 
    {
        Answer1.text = "";
        Answer2.text = "";
        Answer3.text = "";
        Answer4.text = "";
    }

    void accept_data()
    {
        //Debug.Log("accept_data() cvalled");
        dataCanvas.SetActive(true);
        Answer1.interactable = true;
        Answer2.interactable = true;
        Answer3.interactable = true;
        Answer4.interactable = true;
    }


}
