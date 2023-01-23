using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RM3Despawner : MonoBehaviour
{
    public RM3Score ScoreRef;// score reference

    private void OnTriggerEnter (Collider other)// upon collision with trigger
    {
        if (other.gameObject.CompareTag("Ragdoll"))// if the tag is a ragdoll (if a ragdoll touched the ground)
        {
            Destroy(other.gameObject);// destroy the ragdoll
            ScoreRef.scoreNum = 0;// sets the score to 0
        }
    }
}
