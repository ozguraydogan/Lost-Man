using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;
    private AudioSource source;

    private bool isMoving;

    public float timeBetweenSteps;
    private float timer;

    private void Start()
    {
        source = GetComponent<AudioSource>();
        
    }

    void Update()
    {
        
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        
        //Ses
        if (x != 0 || z != 0)
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }

        if (isMoving)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                timer = timeBetweenSteps;
                source.Play();
            }
        }
        else
        {
            timer -= timeBetweenSteps;
        }
        
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);
    }
}
