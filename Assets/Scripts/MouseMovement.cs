/*
    Based off of the "FIRST PERSON MOVEMENT in Unity - FPS Controller"
    tutorial by "Brackeys" at "https://youtu.be/_QajrabyTJc?si=xyTmYrDs21s01W4n"
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    public float sensitivity = 100f;
    public Transform playerBody;

    float xRotation = 0;
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    
    void Update()
    {
        float mouseX = Input.GetAxis ("Mouse X") * sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis ("Mouse Y") * sensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp (xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler (xRotation, 0f, 0f);
        playerBody.Rotate (Vector3.up * mouseX);
    }
}
