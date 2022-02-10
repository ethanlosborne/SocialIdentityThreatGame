using UnityEngine;
using UnityEngine.UI;
using System;
using Ink.Runtime;
using UnityEngine.SceneManagement;

// This is a super bare bones example of how to play and display a ink story in Unity.
public class BasicInkExample : MonoBehaviour {
    public static event Action<Story> OnCreateStory;
	
    void Awake () {
		// Remove the default message
		RemoveChildren();
		StartStory();
	}
    void Update()
    {
        //used to proceed with the story. fill textbox, type of thing.
        if (allowContinue && InkSettings.showingSettings == false && Input.GetKeyDown(KeyCode.Space))
        {
            RefreshView();
        }
        
    }

    // Creates a new Story object with the compiled story which we can then play!
    // Also, links external functions.
    void StartStory () {
		story = new Story (inkJSONAsset.text);
        if(OnCreateStory != null) OnCreateStory(story);

        //link external functions
        dummy.link_external_functions(story);

        RefreshView();
	}
	
	// This is the main function called every time the story changes. It does a few things:
	// Destroys all the old content and choices.
	// Continues over all the lines of text, then displays all the choices. If there are no choices, the story is finished!
	public void RefreshView() {
		// Remove all the UI on screen
		RemoveChildren();

        //display text one line at a time. this is necessary so it will properly fit in the
        //text box frame.
        if (story.canContinue)
        {
            string toShow = story.Continue().Trim();
            if (toShow.Length > 0)
            {
                CreateContentView(toShow);
            }
            else
            {
                RefreshView();
            }
            
        }        
        else if (story.currentChoices.Count > 0) // Display all the choices, if there are any!
        {           
            for (int i = 0; i < story.currentChoices.Count; i++)
            {
                Choice choice = story.currentChoices[i];
                Button button = CreateChoiceView(choice.text.Trim());
                // Tell the button what to do when we press it
                button.onClick.AddListener(delegate { OnClickChoiceButton(choice); });
            }
        }
        // If we've read all the content and there's no choices, the story is finished!
        else
        {
            //load the memory test scene.
            SceneManager.LoadScene("WM Scene");

            /*
            Button choice = CreateChoiceView("End of story.\nRestart?");
            choice.onClick.AddListener(delegate {
                StartStory();
            });
            */
        }
    }
	
    public void enable_input()
    {
        //called from DummyUI after the textbox has finished displaying.
        allowContinue = true;
    }

	// When we click the choice button, tell the story to choose that choice!
	void OnClickChoiceButton (Choice choice) {
        Debug.Log("OnClickChoiceButton() called");
        dummy.play_button_click_sound();
        story.ChooseChoiceIndex(choice.index);
		RefreshView();
	}

	// Creates a textbox showing the the line of text
	void CreateContentView (string text) {
        /*
		Text storyText = Instantiate(textPrefab) as Text;
		storyText.text = text;
		storyText.transform.SetParent (canvas.transform, false);
        */
        allowContinue = false;

        dummy.set_textBox(text);
	}

	// Creates a button showing the choice text
	Button CreateChoiceView (string text) {
		// Creates the button from a prefab
		Button choice = Instantiate (buttonPrefab) as Button;
		choice.transform.SetParent (canvas.transform, false);
		
		// Gets the text from the button prefab
		Text choiceText = choice.GetComponentInChildren<Text> ();
		choiceText.text = text;

		// Make the button expand to fit the text
		//VerticalLayoutGroup layoutGroup = choice.GetComponent<VerticalLayoutGroup>();
		//layoutGroup.childForceExpandHeight = false;

		return choice;
	}

	// Destroys all the children of this gameobject (all the UI)
	void RemoveChildren () {
		int childCount = canvas.transform.childCount;
		for (int i = childCount - 1; i >= 0; --i) {
			GameObject.Destroy(canvas.transform.GetChild (i).gameObject);
		}
	}

	[SerializeField]
	private TextAsset inkJSONAsset = null;
	public Story story;

    //the ui. needs a ref in this file.
    [SerializeField] private DummyUI dummy;
    private bool allowContinue;

	[SerializeField]
	private Canvas canvas = null;
    
	// UI Prefabs
	[SerializeField]
	private Text textPrefab = null;
	[SerializeField]
	private Button buttonPrefab = null;
}
