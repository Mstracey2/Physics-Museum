using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Despawner : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)//contact with trigger box
    {
        if (other.gameObject.CompareTag("DodgeBall"))// if the tag is equal to dodgeball
        {
            Destroy(other.gameObject);// destroys the object
        }
    }
}
