using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class NotebookPanel : MonoBehaviour
{
    public static bool notebookIsOpen = false;

    public GameObject notebookUI;
    public CanvasGroup canvasGroup;
    void Start()
    {
    }


    void Update()
    {
        Debug.Log(notebookIsOpen);

        if (Input.GetKeyDown(KeyCode.G))
        {
            Debug.Log(notebookIsOpen);
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

    void closeNotebook()
    {
        notebookUI.SetActive(false);
        notebookIsOpen = false;
    }
    void openNotebook()
    {
        notebookUI.SetActive(true);
        notebookIsOpen = true;
    }
}
