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
    // enum Operator {add, sub};
	
    // Start is called before the first frame update
    void Start()
    {   
        StartCoroutine(WMCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator WMCoroutine()
    {
        
        List <int> medium = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        List <int> hard = new List<int>() { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
        List <int> usedNumbers = new List<int>();
        // char[] operators = new char[2];
        // new char[0] = '+';
        // new char[1] = '-';
        yield return new WaitForSeconds(6.5f);
   		int num1 = Random.Range(1, medium.Count);
        medium.Remove(num1);
        usedNumbers.Add(num1);
        Box1.text = "+" + num1;
	    Box2.text = " ";
	    Box3.text = " ";
	    Box4.text = " ";
        
        
        yield return new WaitForSeconds(3.0f);
        int num2 = Random.Range(1, medium.Count);
        medium.Remove(num2);
        if (!usedNumbers.Contains(num2) == true)
        {
        	usedNumbers.Add(num2);
        } else {
        	num2 = Random.Range(1, medium.Count);
        	usedNumbers.Add(num2);
        }
        Box4.text = "+" + num2;
        Box1.text = " ";
        Box2.text = " ";
        Box3.text = " ";
        
        yield return new WaitForSeconds(3.0f);
        int num3 = Random.Range(1, medium.Count);
        medium.Remove(num3);
        if (!usedNumbers.Contains(num3) == true)
        {
        	usedNumbers.Add(num3);
        } else {
        	num3 = Random.Range(1, medium.Count);
        	usedNumbers.Add(num3);
        }
        Box3.text = "-" + num3;
        Box1.text = " ";
        Box2.text = " ";
        Box4.text = " ";

        yield return new WaitForSeconds(3.0f);
        int num4 = Random.Range(1, medium.Count);
        medium.Remove(num4);
        if (!usedNumbers.Contains(num4) == true)
        {
        	usedNumbers.Add(num4);
        } else {
        	num4 = Random.Range(1, medium.Count);
        	usedNumbers.Add(num4);
        }
        Box2.text = "+" + num4;
        Box1.text = " ";
        Box3.text = " ";
        Box4.text = " ";
        
        yield return new WaitForSeconds(3.0f);
        int num5 = Random.Range(1, medium.Count);
        medium.Remove(num5);
        if (!usedNumbers.Contains(num5) == true)
        {
        	usedNumbers.Add(num5);
        } else {
        	num5 = Random.Range(1, medium.Count);
        	usedNumbers.Add(num5);
        }
        Box4.text = "-" + num5;
        Box1.text = " ";
        Box2.text = " ";
        Box3.text = " ";
        
        yield return new WaitForSeconds(3.0f);
        int num6 = Random.Range(1, medium.Count);
        medium.Remove(num6);
        if (!usedNumbers.Contains(num6) == true)
        {
        	usedNumbers.Add(num6);
        } else {
        	num6 = Random.Range(1, medium.Count);
        	usedNumbers.Add(num6);
        }
        Box3.text = "-" + num6;
        Box1.text = " ";
        Box2.text = " ";
        Box4.text = " ";
        foreach (int num in usedNumbers)
	        {
	        	Debug.Log(num);
	        }
	        // foreach (int numb in medium)
	        // {
	        // 	Debug.Log(numb);
	        // }
        
    }
}
