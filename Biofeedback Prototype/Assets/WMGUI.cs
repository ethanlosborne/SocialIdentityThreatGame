using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class WMGUI : MonoBehaviour
{
    public Text Box1;
    public Text Box2;
    public Text Box3;
    public Text Box4;
    public InputField Answer1;
    public InputField Answer2;
    public InputField Answer3;
    public InputField Answer4;
    private int count;
    public GameObject wMCanvas;
    public GameObject dataCanvas; 
    
    // Start is called before the first frame update
    void Start()
    {   
        StartCoroutine(WMCoroutineMed1());
        dataCanvas.SetActive(false);
    }
    // Handles switching of coroutines on button click
    public void CoroutineSwitcher()
    {
        switch (count)
        {
            case 1:
                StartCoroutine(WMCoroutineMed2());
                wMCanvas.SetActive(true);
                dataCanvas.SetActive(false);
                ClearInputText();
                break;
            case 2:
                StartCoroutine(WMCoroutineMed3());
                wMCanvas.SetActive(true);
                dataCanvas.SetActive(false);
                ClearInputText();
                break;
            case 3:
                StartCoroutine(WMCoroutineHard1());
                wMCanvas.SetActive(true);
                dataCanvas.SetActive(false);
                ClearInputText();
                break;
            case 4:
                StartCoroutine(WMCoroutineHard2());
                wMCanvas.SetActive(true);
                dataCanvas.SetActive(false);
                ClearInputText();
                break;
            case 5:
                StartCoroutine(WMCoroutineHard3());
                wMCanvas.SetActive(true);
                dataCanvas.SetActive(false);
                ClearInputText();
                break;
            default:
                Debug.Log("Default case");
                break;
        }
        if (count >= 6)
        {
            StopCoroutine(WMCoroutineHard3());
        }
    }
    IEnumerator WMCoroutineMed1()
    {
        yield return new WaitForSeconds(6.5f);
        Box1.text = "+" + 5;
        Box2.text = " ";
        Box3.text = " ";
        Box4.text = " ";
        
        yield return new WaitForSeconds(3.0f);
        Box4.text = "+" + 6;
        Box1.text = " ";
        Box2.text = " ";
        Box3.text = " ";

        yield return new WaitForSeconds(3.0f);
        Box3.text = "-" + 1;
        Box1.text = " ";
        Box2.text = " ";
        Box4.text = " ";
        
        yield return new WaitForSeconds(3.0f);  
        Box2.text = "+" + 4;
        Box1.text = " ";
        Box3.text = " ";
        Box4.text = " ";
        
        yield return new WaitForSeconds(3.0f);
        Box4.text = "-" + 8;
        Box1.text = " ";
        Box2.text = " ";
        Box3.text = " ";
        
        yield return new WaitForSeconds(3.0f);
        Box3.text = "-" + 3;
        Box1.text = " ";
        Box2.text = " ";
        Box4.text = " ";

        yield return new WaitForSeconds(3.0f);
        wMCanvas.SetActive(false);
        dataCanvas.SetActive(true);
        count ++;
        
    }
    IEnumerator WMCoroutineMed2()
    {
        Box1.text = "1";
        Box2.text = "2";
        Box3.text = "3";
        Box4.text = "4";

        yield return new WaitForSeconds(6.5f);
        Box1.text = "+" + 5;
        Box2.text = " ";
        Box3.text = " ";
        Box4.text = " ";
        
        yield return new WaitForSeconds(3.0f);
        Box4.text = "+" + 6;
        Box1.text = " ";
        Box2.text = " ";
        Box3.text = " ";

        yield return new WaitForSeconds(3.0f);
        Box3.text = "-" + 1;
        Box1.text = " ";
        Box2.text = " ";
        Box4.text = " ";
        
        yield return new WaitForSeconds(3.0f);  
        Box2.text = "+" + 4;
        Box1.text = " ";
        Box3.text = " ";
        Box4.text = " ";
        
        yield return new WaitForSeconds(3.0f);
        Box4.text = "-" + 8;
        Box1.text = " ";
        Box2.text = " ";
        Box3.text = " ";
        
        yield return new WaitForSeconds(3.0f);
        Box3.text = "-" + 3;
        Box1.text = " ";
        Box2.text = " ";
        Box4.text = " ";
        
        yield return new WaitForSeconds(3.0f);
        wMCanvas.SetActive(false);
        dataCanvas.SetActive(true);
        count ++;
    }
    IEnumerator WMCoroutineMed3()
    {
        Box1.text = "1";
        Box2.text = "2";
        Box3.text = "3";
        Box4.text = "4";

        yield return new WaitForSeconds(6.5f);
        Box1.text = "+" + 5;
        Box2.text = " ";
        Box3.text = " ";
        Box4.text = " ";
        
        yield return new WaitForSeconds(3.0f);
        Box4.text = "+" + 6;
        Box1.text = " ";
        Box2.text = " ";
        Box3.text = " ";

        yield return new WaitForSeconds(3.0f);
        Box3.text = "-" + 1;
        Box1.text = " ";
        Box2.text = " ";
        Box4.text = " ";
        
        yield return new WaitForSeconds(3.0f);  
        Box2.text = "+" + 4;
        Box1.text = " ";
        Box3.text = " ";
        Box4.text = " ";
        
        yield return new WaitForSeconds(3.0f);
        Box4.text = "-" + 8;
        Box1.text = " ";
        Box2.text = " ";
        Box3.text = " ";
        
        yield return new WaitForSeconds(3.0f);
        Box3.text = "-" + 3;
        Box1.text = " ";
        Box2.text = " ";
        Box4.text = " ";
        
        yield return new WaitForSeconds(3.0f);
        wMCanvas.SetActive(false);
        dataCanvas.SetActive(true);
        count ++;
    }
    IEnumerator WMCoroutineHard1()
    {
        Box1.text = "1";
        Box2.text = "2";
        Box3.text = "3";
        Box4.text = "4";

        yield return new WaitForSeconds(6.5f);
        Box1.text = "+" + 14;
        Box2.text = " ";
        Box3.text = " ";
        Box4.text = " ";
        
        yield return new WaitForSeconds(3.0f);
        Box4.text = "+" + 11;
        Box1.text = " ";
        Box2.text = " ";
        Box3.text = " ";

        yield return new WaitForSeconds(3.0f);
        Box3.text = "-" + 15;
        Box1.text = " ";
        Box2.text = " ";
        Box4.text = " ";
        
        yield return new WaitForSeconds(3.0f);  
        Box2.text = "+" + 16;
        Box1.text = " ";
        Box3.text = " ";
        Box4.text = " ";
        
        yield return new WaitForSeconds(3.0f);
        Box4.text = "-" + 10;
        Box1.text = " ";
        Box2.text = " ";
        Box3.text = " ";
        
        yield return new WaitForSeconds(3.0f);
        Box3.text = "-" + 19;
        Box1.text = " ";
        Box2.text = " ";
        Box4.text = " ";
        
        yield return new WaitForSeconds(3.0f);
        wMCanvas.SetActive(false);
        dataCanvas.SetActive(true);
        count ++;
    }
    IEnumerator WMCoroutineHard2()
    {
        Box1.text = "1";
        Box2.text = "2";
        Box3.text = "3";
        Box4.text = "4";

        yield return new WaitForSeconds(6.5f);
        Box1.text = "+" + 18;
        Box2.text = " ";
        Box3.text = " ";
        Box4.text = " ";
        
        yield return new WaitForSeconds(3.0f);
        Box4.text = "+" + 12;
        Box1.text = " ";
        Box2.text = " ";
        Box3.text = " ";

        yield return new WaitForSeconds(3.0f);
        Box3.text = "-" + 13;
        Box1.text = " ";
        Box2.text = " ";
        Box4.text = " ";
        
        yield return new WaitForSeconds(3.0f);  
        Box2.text = "+" + 14;
        Box1.text = " ";
        Box3.text = " ";
        Box4.text = " ";
        
        yield return new WaitForSeconds(3.0f);
        Box4.text = "-" + 10;
        Box1.text = " ";
        Box2.text = " ";
        Box3.text = " ";
        
        yield return new WaitForSeconds(3.0f);
        Box3.text = "-" + 16;
        Box1.text = " ";
        Box2.text = " ";
        Box4.text = " ";
        
        yield return new WaitForSeconds(3.0f);
        wMCanvas.SetActive(false);
        dataCanvas.SetActive(true);
        count ++;
    }
    IEnumerator WMCoroutineHard3()
    {
        Box1.text = "1";
        Box2.text = "2";
        Box3.text = "3";
        Box4.text = "4";

        yield return new WaitForSeconds(6.5f);
        Box1.text = "+" + 18;
        Box2.text = " ";
        Box3.text = " ";
        Box4.text = " ";
        
        yield return new WaitForSeconds(3.0f);
        Box4.text = "+" + 10;
        Box1.text = " ";
        Box2.text = " ";
        Box3.text = " ";

        yield return new WaitForSeconds(3.0f);
        Box3.text = "-" + 17;
        Box1.text = " ";
        Box2.text = " ";
        Box4.text = " ";
        
        yield return new WaitForSeconds(3.0f);  
        Box2.text = "+" + 11;
        Box1.text = " ";
        Box3.text = " ";
        Box4.text = " ";
        
        yield return new WaitForSeconds(3.0f);
        Box4.text = "-" + 15;
        Box1.text = " ";
        Box2.text = " ";
        Box3.text = " ";
        
        yield return new WaitForSeconds(3.0f);
        Box3.text = "-" + 12;
        Box1.text = " ";
        Box2.text = " ";
        Box4.text = " ";
        
        yield return new WaitForSeconds(3.0f);
        wMCanvas.SetActive(false);
        dataCanvas.SetActive(true);
        count ++;
    }
    //clears text areas after button click
    void ClearInputText() 
    {
        Answer1.text = "";
        Answer2.text = "";
        Answer3.text = "";
        Answer4.text = "";
    }
}
