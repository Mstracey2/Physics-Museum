using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{

    public float mouseSensitivity = 25f;// mouse sensitivity 

    public Transform playerBody;// player's facing position

    float xRotation = 0f;// x axis rotation

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // locks curser into application
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;// gets the x axis of mouse and times it by the mouse sensitivity 
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;// gets the y axis of mouse and times it by the mouse sensitivity 

        xRotation -= mouseY;// rotation of player is moved by the mouseX
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);// rotates player
    }
}
