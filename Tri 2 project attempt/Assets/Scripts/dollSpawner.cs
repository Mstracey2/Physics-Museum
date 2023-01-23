using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dollSpawner : MonoBehaviour
{
    public GameObject spawner; //object that will be spawned
    
    public bool stop = false;// stop the spawner
    public bool start = false;// start the spawner
    float randomNumber;

    void Start()//upon start
    {
        SpawnObject();//spawns object
    }

    public void SpawnObject()
    {
        randomNumber = Random.Range(1, 20); // randomizes the time to spawn the next object
        if (start == true)
        {
            Instantiate(spawner, transform.position, transform.rotation);//spawns object at the position of the object attatched
        }
        
        start = true;// stops all objects spawning at once on startup
        
        Invoke("SpawnObject", randomNumber);// runs the code again when when the timer reaches random number
    }
}
