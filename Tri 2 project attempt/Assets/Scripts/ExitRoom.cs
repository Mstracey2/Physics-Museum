using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitRoom : MonoBehaviour
{
    public RM1Score ScoreRef; // the score
    public GameObject player; // player capsule

    // Update is called once per frame
    private void OnTriggerExit(Collider other)//upon leaving the room
    {
        if(other.gameObject.CompareTag ("Player"))// if its the player
        {
            ScoreRef.scoreNum = 0;// sets the score back to 0
        }
    }
}
