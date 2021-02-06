using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Manager;
    public GameObject finish;
    private void Awake()
    {
        Manager = this;
    }

    public void Restart()
    {
        SceneManager.LoadScene("Start");
    }
    

    public float Time = 1f;
}
