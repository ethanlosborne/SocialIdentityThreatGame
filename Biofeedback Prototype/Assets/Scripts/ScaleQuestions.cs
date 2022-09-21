using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScaleQuestions : MonoBehaviour
{
    //after the wm test, control is passed to here.

    //we show the questions in order, in the format:
    // question text
    // scale (1-7), (clicking button submits and moves to next question)
    [SerializeField] private WMSplashManager splash;

    [SerializeField] private Image bg;
    [SerializeField] private Text questionText;
    [SerializeField] private Button[] scaleButtons; //7 of them

    private int id;
    private List<string> questions = new List<string>() {
        "[This company] is a place where I am likely to feel intrinsically motivated by my own goals.",
        "Standards of success at [this company] match what I think it means to be successful.",
        "I feel that [this company] is a place that will allow me to realize my own goals.",
        "I am the kind of person who can succeed in science.",
        "I think that science is fascinating.",
        "I feel at home in science.",
        "Sometimes I feel like I donÅft belong in science.",
        "I don't think I could ever really feel comfortable in science.",
        "This is a good company to intern, for students like me.",
        "This is the right internship for me to be taking now.",
        "During my time with this company, I felt like an outsider.",
        "I feel like I fit in well with the other interns that have worked for this company previously.",
        "IÅfm not really sure that this company is the right one for me."
    };
    public static List<int> answers = new List<int>();

    public void begin()
    {
        //called by wmgui after the test is over
        bg.gameObject.SetActive(true);
        id = 0;
        questionText.text = questions[id];
    }
    public void next(int answerId)
    {
        //called by scale buttons
        if (id == questions.Count - 1)
        {
            //then finish
            foreach(Button b in scaleButtons)
            {
                b.interactable = false;
            }
            splash.show_ending();
        }
        else
        {
            //record answer and move on
            answers.Add(answerId);
            //Debug.Log("answered " + answerId);

            //display the question corresponding to the id
            id++;
            questionText.text = "(" + id + "/12) " + questions[id];           
        }
        
    }


}
