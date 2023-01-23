using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class RM1Score : MonoBehaviour
{
    public TMP_Text score; // current score
    public HighScore HscoreRef;// high score
    public int scoreNum = 0;// the current number

    void Update()// upon every frame
    {
        score.text = "Score:" + scoreNum.ToString();// writes the score
        HscoreRef.scoreNum = scoreNum;// sets the highscores score number to equal this score number
    }
}
