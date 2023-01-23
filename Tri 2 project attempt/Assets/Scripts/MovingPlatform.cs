using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public GameObject platform; //platform being moved
    public GameObject end;// location of point to be moved to
    public Vector3 endOne;// the vector of the end point

    private void Start()// on start
    {
        endOne = end.transform.position;// end vector = end point vector
    }
    private void OnTriggerEnter(Collider other)// upon collision with trigger
    {
        if (other.gameObject.CompareTag  ("Player"))// if the object was the player
        {
            platform.transform.position = endOne;// move the platform to the end point position
        }
    }
}
