/*
    Based off of the "FIRST PERSON MOVEMENT in Unity - FPS Controller"
    tutorial by "Brackeys" at "https://youtu.be/_QajrabyTJc?si=xyTmYrDs21s01W4n"
*/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 1.78816f;
    
    void Update()
    {
        float x = Input.GetAxis ("Horizontal");
        float z = Input.GetAxis ("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        move = Vector3.ClampMagnitude (move * speed, speed);

        controller.Move (move * Time.deltaTime);

        if (transform.position.z > 0)
        {
            transform.position = new Vector3 (transform.position.x, transform.position.y, 0f);
        }

    }
}
