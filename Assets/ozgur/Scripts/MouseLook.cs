﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensetivity = 100f;
    public Transform playerBody;
    private float xRotation = 0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X")*mouseSensetivity*Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y")*mouseSensetivity*Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -100f, 100f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        
        playerBody.Rotate(Vector3.up*mouseX);
    }
}
