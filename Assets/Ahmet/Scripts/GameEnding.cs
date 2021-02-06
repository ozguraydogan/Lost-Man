using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameEnding : MonoBehaviour
{
    public Button restartButton;
    public Text lastWord;
    public GameObject lastPanelUI;

    public static bool isGameFinished = false;

    void Start()
    {
        restartButton.onClick.AddListener(loadFirstScene);
        allDoUnvisible();
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameFinished)
        {
            visibleLast();
        }
    }

    void loadFirstScene()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            Application.LoadLevel("Start");
        }
        
    }

    void allDoUnvisible()
    {
        lastPanelUI.SetActive(false);
    }

    void visibleLast()
    {
        lastPanelUI.SetActive(true);
    }
}

