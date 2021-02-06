using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ClosingTexts : MonoBehaviour
{
    // son trigger devreye girince, ekranda bi text belirsin, son cumleyi desin ve ardindan bizim image girsin
    //metin -> adimiz -> restrat butonu ve ilk sahne yuklensin
    public static bool isLastTrigger = false;
    public Text lastText;
    public Image lastImage;
    public Button restartButton;

    // Start is called before the first frame update
    void Start()
    {
        allElementDoIinvisible();
        restartButton.onClick.AddListener(restartGame);
    }

    // Update is called once per frame
    void Update()
    {
        if(isLastTrigger == true)
        {
            //
        }
    }
    void allElementDoIinvisible()
    {
        lastImage.enabled = false;
        lastText.enabled = false;

        restartButton.enabled = false;
        restartButton.image.enabled = false;
        restartButton.GetComponentInChildren<Text>().enabled = false;
    }
    void restartGame()
    {
        /*   Application.LoadLevel("buraya ilk scene adi gelecek");   */
    }
}
