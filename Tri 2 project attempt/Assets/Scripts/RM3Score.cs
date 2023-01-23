using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class RM3Score : MonoBehaviour
{
    public TMP_Text score;// current score
    public HighScore HscoreRef;// high score
    public int scoreNum = 0;// current number

    void Update()// up each frame
    {
        score.text = "Score:" + scoreNum.ToString();// write the score
        HscoreRef.scoreNum = scoreNum; // sets the highscores score number to equal this score number
    }
}
