using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HighScore : MonoBehaviour
{
    public TMP_Text score;// current score
    public int scoreNum = 0;// current number
    public int HScore = 0;// high score

    // Update is called once per frame
    void Update()
    {
        if (scoreNum >= HScore)// if the current score is above the highscore
        {
            HScore = scoreNum;// new highscore = the current score
            
        }
        
        score.text = "HighScore:" + HScore.ToString();// prints the score on the text
    }
}
