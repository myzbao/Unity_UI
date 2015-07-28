//-----------------------------------------
//   Jason Walters
//   http://glitchbeam.com
//   @jasonrwalters
//
//   last edit on 7/28/2015
//-----------------------------------------

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreController : MonoBehaviour
{
    private Text txt;

    void OnEnable()
    {
        // reference components
        txt = GetComponent<Text>();
    }

    void OnDisable()
    {
        // clear the text
        txt.text = string.Empty;
    }

    // Update is called once per frame
    void Update()
    {
        float gameScore = GameController.gameScore;
        float gameHighScore = GameController.gameHighScore;

        // update the score based on following object names
        if (gameObject.name == "MainMenu_Text_HighScore")
        {
            txt.text = "Highscore " + gameHighScore;
        }
        else if (gameObject.name == "GamePlay_Text_Score_Time")
        {
            txt.text = "Score " + gameScore;
        }
        else if (gameObject.name == "GameOver_Text_Score_Time")
        {
            txt.text = "You survived " + gameScore + " seconds";
        }
    }
}
