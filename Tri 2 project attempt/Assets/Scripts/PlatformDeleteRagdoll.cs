using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDeleteRagdoll : MonoBehaviour
{
    public RM3Score ScoreRef;// current score

    void OnTriggerEnter (Collider col)// upon collsion with trigger
    {
        if (col.gameObject.CompareTag ("Ragdoll"))// if tag is equal to ragdoll
        {
            Destroy(col.gameObject);// destroys the ragdoll
            ScoreRef.scoreNum = ScoreRef.scoreNum + 10;// adds 10 points to the current score
        }
    }




}
