using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TP : MonoBehaviour
{
    public Transform TpLocation;// location of teleportation
    public GameObject ball;// object to spawn
    public RM1Score ScoreRef;// current score

    private void OnTriggerEnter(Collider other)// if a object collides with trigger
    {

        if (other.gameObject.CompareTag("DodgeBall"))// if dodgeball
        {
            Destroy(other.gameObject);//destroy dodgball

            Instantiate(ball, TpLocation);// creates a new ball at point of teleportation
        }

        if (other.gameObject.CompareTag("TargetCube"))// if cube
        {
            Destroy(other.gameObject);// destroy the cube

            ScoreRef.scoreNum += 10;// adds 10 to the score
            
        }

    }
}
