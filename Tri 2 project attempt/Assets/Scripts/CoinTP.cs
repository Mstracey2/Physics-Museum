using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinTP : MonoBehaviour
{
    public Transform TpLocation;// location of teleport
    public GameObject Coin;//coin object

    private void OnTriggerEnter(Collider other)//contact with trigger box
    {
        if (other.gameObject.CompareTag("Coin"))// if tag is equal to Coin
        {
            Destroy(other.gameObject);// destroys the coin contact with trigger

            Instantiate(Coin, TpLocation);// spawns a new coin at the location of teleport
        }
    }
}
