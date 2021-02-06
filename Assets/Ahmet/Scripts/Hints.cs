using UnityEngine;
using UnityEngine.UI;

public class Hints : MonoBehaviour
{
    [SerializeField] Sprite[] hints;

    Image hintImage;
    public static bool hintImageChanged = false;

    void Start()
    {
        hintImage = gameObject.GetComponent<Image>();
        hintImage.sprite = hints[0];
    }

    void Update()
    {
        changeHintImage();    
    }

    public void changeHintImage()
    {
        //Gelen degisiklik bool inputuna gore function calissin ama sonra
        hintImage.sprite = hints[Puzzles.puzzleNumber];
    }
}

