using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CanvasManagment : MonoBehaviour
{
    public GameObject notebookUI;
    public GameObject hintUI;
    public Image notebookIcon;

    public static bool accessibleHintButton = false;
    public static bool hintIsOpen = false;
    public static bool notebookIsOpen = false;

    void Start()
    {
        notebookUI.SetActive(false);
        hintUI.SetActive(false);
    }


    void Update()
    {
        keyInputForNotebookPanel();
        keyInputForHint();
    }

    void keyInputForNotebookPanel()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            if (!notebookIsOpen)
            {
                openNotebook();
            }
            else
            {
                closeNotebook();
            }
        }
    }
    void keyInputForHint()
    {

        if (accessibleHintButton && Input.GetKeyDown(KeyCode.H))
        {
            if (!hintIsOpen)
            {
                hintUI.SetActive(true);
                hintIsOpen = true;
            }
            else
            {
                hintUI.SetActive(false);
                hintIsOpen = false;
            }
        }
    }

    void closeNotebook()
    {
        notebookUI.SetActive(false);
        notebookIsOpen = false;
        notebookIcon.enabled = true;

        accessibleHintButton = false;
        hintUI.SetActive(false);

    }
    void openNotebook()
    {
        notebookUI.SetActive(true);
        notebookIsOpen = true;
        notebookIcon.enabled = false;

        accessibleHintButton = true;
    }
}
