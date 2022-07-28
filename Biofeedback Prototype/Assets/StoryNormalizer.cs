using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StoryNormalizer
{
    //the purpose of this class is for making sure each story line conforms to the [658] character limit.
    //it will read every line of the story and check. (excluding choices or commands).
    //if the line violates the limit, then it will output the offending line in the story in the debug log.
    //(at which point human intervention is necessary to break the line.)


    public static void check_story(Ink.Runtime.Story story)
    {
        //for each text line in story, check line.

        while (story.canContinue)
        {
            check_line_against_limit(story.Continue().Trim());
            //ignore button text.
        }

        Debug.Log("End of story reached.");

    }
    
    public static void check_line_against_limit(string line)
    {
        Debug.Log(line.Length);
        if (line.Length > 600) Debug.Log("offending line: " + line);

    }



}
