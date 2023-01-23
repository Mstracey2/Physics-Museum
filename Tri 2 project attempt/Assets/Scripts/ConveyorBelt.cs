using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorBelt : MonoBehaviour
{

    public float speed;// speed of the object on belt
    Rigidbody rBody;// object

    void Start()
    {
        rBody = GetComponent<Rigidbody>();// gets the component of the object
    }

    void FixedUpdate()// calls every frame
    {

        Vector3 pos = rBody.position;// vector3 variable that is equal to the position of object's vector3
        rBody.position += Vector3.back * speed * Time.fixedDeltaTime;// adds the vector to the original position (times by the speed)
        rBody.MovePosition(pos);// changes the position relative to the orignal position.

    }

   
}
