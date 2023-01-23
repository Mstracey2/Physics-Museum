using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHolder : MonoBehaviour
{
    [SerializeField] Camera cam;// the players camera
    [SerializeField] float maxGrabDistance = 10f, throwForce = 50f, lerpSpeed = 10f;// the max distance the player can grab an object from, the throw force, the speed in which the object reaches the position
    [SerializeField] Transform objectHolder;

    Rigidbody grabbedRB;// checks to see if an object is grabbed

    // Update is called once per frame
    void Update()
    {
        if (grabbedRB)
        {
            grabbedRB.MovePosition(Vector3.Lerp(grabbedRB.position, objectHolder.transform.position, Time.deltaTime * lerpSpeed));// moves the object grabbed to the new position of the holder

            if (Input.GetMouseButtonDown(0))// if left clicked
            {
                grabbedRB.isKinematic = false;// abides to gravity
                grabbedRB.AddForce(cam.transform.forward * throwForce, ForceMode.VelocityChange);// throws the object
                grabbedRB = null;// object is no longer grabbed
            }
        }

        if (Input.GetKeyDown(KeyCode.E))// if the player tries to pickup an object
        {
            if (grabbedRB)// if the player already picked up something
            {
                // drops the object
                grabbedRB.isKinematic = false;
                grabbedRB = null;
            }
            else
            {
                RaycastHit hit;// checks if there is an object over the players curser
                Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f));// checks the ray with the players viewpoint
                if(Physics.Raycast(ray, out hit, maxGrabDistance))// if the object is within distance
                {
                   
                    if(hit.collider.gameObject.CompareTag("DodgeBall") || hit.collider.gameObject.CompareTag("Coin"))// if the object is a ball or coin
                    {
                        grabbedRB = hit.collider.gameObject.GetComponent<Rigidbody>();// the object is grabbed
                    }
                    if (grabbedRB)
                    {
                        grabbedRB.isKinematic = true;// drops the object in hand
                    }
                }
            }
        }
    }
}
