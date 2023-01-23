using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBlueCube : MonoBehaviour
{
    void OnCollisionEnter(Collision col)// upon collision with another object
    {
        if (col.gameObject.name == "BlueCubeTarget(Clone)")// if the name is equal to BlueCubeTarget(Clone)
        {
            Destroy(col.gameObject);//destroys the object (cube)
        }
    }
}
