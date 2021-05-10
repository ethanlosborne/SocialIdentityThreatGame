IEnumerator WMCoroutine()
    {
        
        int[] medium = {1, 2, 3, 4, 5, 6, 7, 8, 9};
        int[] hard = {10, 11, 12, 13, 14, 15, 16, 17, 18, 19};
        List <int> usedNumbers = new List<int>();
        char[] operators = new char[2];
        char[0] = '+';
        char[1] = '-';
        
        yield return new WaitForSeconds(6.5f);
        int num1 = Random[medium];
        usedNumbers.Add(num1);
        Box1.text = Random[operators] + num1;
        Box2.text = " ";
        Box3.text = " ";
        Box4.text = " ";
        
        yield return new WaitForSeconds(3.0f);
        int num2 = Random.Range(1, 10);
        Box4.text = "+" + num2;
        Box1.text = " ";
        Box2.text = " ";
        Box3.text = " ";
        
        yield return new WaitForSeconds(3.0f);
        int num3 = Random.Range(1, 10);
        Box3.text = "-" + num3;
        Box1.text = " ";
        Box2.text = " ";
        Box4.text = " ";

        yield return new WaitForSeconds(3.0f);
        int num4 = Random.Range(1, 10);
        Box2.text = "+" + num4;
        Box1.text = " ";
        Box3.text = " ";
        Box4.text = " ";
        
        yield return new WaitForSeconds(3.0f);
        int num5 = Random.Range(1, 10);
        Box4.text = "-" + num5;
        Box1.text = " ";
        Box2.text = " ";
        Box3.text = " ";
        
        yield return new WaitForSeconds(3.0f);
        int num6 = Random.Range(1, 10);
        Box3.text = "-" + num6;
        Box1.text = " ";
        Box2.text = " ";
        Box4.text = " ";  
    }

    yield return new WaitForSeconds(6.5f);
        int num1 = Random.Range(1, medium.Count);
        foreach (int nums in medium)
        {
            result += nums.ToString() + ", ";
        }
        Debug.Log("Before removing num1");
        Debug.Log(result);
        medium.Remove(num1);
        Debug.Log("After removing num1");
        foreach (int nums in medium)
        {
            result += nums.ToString() + ", ";
        }
        Debug.Log(result);
        foreach (int num in usedNumbers)
        {
            result += num.ToString() + ", ";
        }
        Debug.Log("Before adding num1");
        Debug.Log(result);
        usedNumbers.Add(num1);
        foreach (int num in usedNumbers)
        {
            result += num.ToString() + ", ";
        }
        Debug.Log("After adding num1");
        Debug.Log(result);
        Box1.text = "+" + num1;
        Box2.text = " ";
        Box3.text = " ";
        Box4.text = " ";
        
        
        yield return new WaitForSeconds(3.0f);
        int num2 = Random.Range(1, medium.Count);
        foreach (int nums in medium)
        {
            result += nums.ToString() + ", ";
        }
        Debug.Log("Before removing num2");
        Debug.Log(result);
        medium.Remove(num2);
        Debug.Log("After removing num2");
        foreach (int nums in medium)
        {
            result += nums.ToString() + ", ";
        }
        Debug.Log(result);
        Debug.Log("Before adding num2");
        foreach (int num in usedNumbers)
        {
            result += num.ToString() + ", ";
        }
        Debug.Log(result);
        while (!usedNumbers.Contains(num2) == true)
        {
            usedNumbers.Add(num2);
        }
        Debug.Log("After adding num2");
        foreach (int num in usedNumbers)
        {
            result += num.ToString() + ", ";
        }
        Debug.Log(result);
        Box4.text = "+" + num2;
        Box1.text = " ";
        Box2.text = " ";
        Box3.text = " ";
        
        yield return new WaitForSeconds(3.0f);
        int num3 = Random.Range(1, medium.Count);
        foreach (int nums in medium)
        {
            result += nums.ToString() + ", ";
        }
        Debug.Log("Before removing num3");
        Debug.Log(result);
        medium.Remove(num3);
        Debug.Log("After removing num3");
        foreach (int nums in medium)
        {
            result += nums.ToString() + ", ";
        }
        Debug.Log(result);
        Debug.Log("Before adding num3");
        foreach (int num in usedNumbers)
        {
            result += num.ToString() + ", ";
        }
        Debug.Log(result);
        while (!usedNumbers.Contains(num3) == true)
        {
            usedNumbers.Add(num3);
        }
        Debug.Log("After adding num3");
        foreach (int num in usedNumbers)
        {
            result += num.ToString() + ", ";
        }
        Debug.Log(result);
        Box3.text = "-" + num3;
        Box1.text = " ";
        Box2.text = " ";
        Box4.text = " ";

        yield return new WaitForSeconds(3.0f);
        int num4 = Random.Range(1, medium.Count);
        foreach (int nums in medium)
        {
            result += nums.ToString() + ", ";
        }
        Debug.Log("Before removing num4");
        Debug.Log(result);
        medium.Remove(num4);
        Debug.Log("After removing num4");
        foreach (int nums in medium)
        {
            result += nums.ToString() + ", ";
        }
        Debug.Log(result);
        Debug.Log("Before adding num4");
        foreach (int num in usedNumbers)
        {
            result += num.ToString() + ", ";
        }
        Debug.Log(result);
        while (!usedNumbers.Contains(num4) == true)
        {
            usedNumbers.Add(num4);
        }
        Debug.Log("After adding num4");
        foreach (int num in usedNumbers)
        {
            result += num.ToString() + ", ";
        }
        Debug.Log(result);
        Box2.text = "+" + num4;
        Box1.text = " ";
        Box3.text = " ";
        Box4.text = " ";
        
        yield return new WaitForSeconds(3.0f);
        int num5 = Random.Range(1, medium.Count);
        foreach (int nums in medium)
        {
            result += nums.ToString() + ", ";
        }
        Debug.Log("Before removing num5");
        Debug.Log(result);
        medium.Remove(num5);
        Debug.Log("After removing num5");
        foreach (int nums in medium)
        {
            result += nums.ToString() + ", ";
        }
        Debug.Log(result);
        Debug.Log("Before adding num5");
        foreach (int num in usedNumbers)
        {
            result += num.ToString() + ", ";
        }
        Debug.Log(result);
        while (!usedNumbers.Contains(num5) == true)
        {
            usedNumbers.Add(num5);
        }
        Debug.Log("After adding num5");
        foreach (int num in usedNumbers)
        {
            result += num.ToString() + ", ";
        }
        Debug.Log(result);
        Box4.text = "-" + num5;
        Box1.text = " ";
        Box2.text = " ";
        Box3.text = " ";
        
        yield return new WaitForSeconds(3.0f);
        int num6 = Random.Range(1, medium.Count);
        foreach (int nums in medium)
        {
            result += nums.ToString() + ", ";
        }
        Debug.Log("Before removing num6");
        Debug.Log(result);
        medium.Remove(num6);
        Debug.Log("After removing num6");
        foreach (int nums in medium)
        {
            result += nums.ToString() + ", ";
        }
        Debug.Log(result);
        Debug.Log("Before adding num6");
        foreach (int num in usedNumbers)
        {
            result += num.ToString() + ", ";
        }
        Debug.Log(result);
        while (!usedNumbers.Contains(num6) == true)
        {
            usedNumbers.Add(num6);
        }
        Debug.Log("After adding num6");
        foreach (int num in usedNumbers)
        {
            result += num.ToString() + ", ";
        }
        Debug.Log(result);
        Box3.text = "-" + num6;
        Box1.text = " ";
        Box2.text = " ";
        Box4.text = " ";






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
    // enum Operator {add, sub};
    
    // Start is called before the first frame update
    void Start()
    {   
        StartCoroutine(WMCoroutineMed1());
        dataCanvas.SetActive(false);
    }
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
    void ClearInputText() 
    {
        Answer1.text = "";
        Answer2.text = "";
        Answer3.text = "";
        Answer4.text = "";
    }
}
