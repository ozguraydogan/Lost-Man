using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puzzles : MonoBehaviour
{
    [SerializeField] Sprite[] puzzles;


    Image puzzleImage;
    public static int puzzleNumber = 0;
    public static int maxVisiblePuzzle = 0;  //Karakter ilerledikce puzzle gorebilme acilacak

    void Start()
    {
        puzzleImage = gameObject.GetComponent<Image>();
        puzzleImage.sprite = puzzles[0];
    }

    void Update()
    {
        imageChanging();
    }

    void imageChanging()
    {
        if (CanvasManagment.notebookIsOpen && Input.GetKeyDown(KeyCode.E))
        {
            nextImages();
        }
        else if (CanvasManagment.notebookIsOpen && Input.GetKeyDown(KeyCode.Q))
        {
            previousImages();
        }

    }
    public void nextImages()
    {
        if((puzzleNumber+1) == maxVisiblePuzzle)
        {
            puzzleNumber = 0;
        }
        else puzzleNumber++;
        puzzleImage.sprite = puzzles[puzzleNumber];
    }

    public void previousImages()
    {
        puzzleNumber--;
        if (puzzleNumber == -1)
        {
            puzzleNumber = (maxVisiblePuzzle - 1);
        }
        puzzleImage.sprite = puzzles[puzzleNumber];
    }
}
