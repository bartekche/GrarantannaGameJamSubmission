using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public static int highscore=0;
    Text highscoretext;
    void Start()
    {
        highscoretext = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Score.score >highscore)
        { highscore = Score.score; }
        highscoretext.text = "REKORD: " + highscore.ToString();
    }
}
