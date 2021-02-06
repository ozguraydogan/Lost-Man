using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OpeningSceneManagment : MonoBehaviour
{
    public Button startButton;
    public Text[] stories;

    void Start()
    {

        allElementDoIinvisibleExceptButton();
        startButton.onClick.AddListener(startGame);
        //startButtonvisibleChancing();
        
    }

    void startGame()
    {
        startButtonvisibleChancing();
        firstStory();
    }

    void firstStory()
    {
        stories[0].enabled = true;
        StartCoroutine(WaitForFirstStoryFinished());
    }

    void secondStory()
    {
        stories[0].enabled = false;
        stories[1].enabled = true;
        StartCoroutine(WaitForSecondStoryFinished());
    }
    private IEnumerator WaitForFirstStoryFinished()
    {
        yield return new WaitForSeconds(5);
        secondStory();
    }


    private IEnumerator WaitForSecondStoryFinished()
    {
        yield return new WaitForSeconds(5);
       /*   Application.LoadLevel("buraya ikinci scene adi gelecek");   */
    }


    void startButtonvisibleChancing()
    {
        if (startButton.enabled == true)
        {
            startButton.enabled = false;
            startButton.image.enabled = false;
            startButton.GetComponentInChildren<Text>().enabled = false;
        }
        else if (startButton.enabled == false)
        {
            startButton.enabled = true;
            startButton.image.enabled = true;
            startButton.GetComponentInChildren<Text>().enabled = true;
        }
    }
    void allElementDoIinvisibleExceptButton()
    {
        foreach (Text t in stories)
        {
            t.enabled = false;
        }
        startButton.enabled = true;
    }
}
