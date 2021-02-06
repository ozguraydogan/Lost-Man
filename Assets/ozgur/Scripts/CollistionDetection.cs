using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CollistionDetection : MonoBehaviour
{
    public GameObject nesne2,nesne3;

   private bool _checkG;
   
   private AudioSource source;

   public Image notebookImage;

   [SerializeField] private Color _color;

   public GameObject task1,task2,task3;   // task 3 e final text veya resim eklenicek
   private void Start()
   {
       StartCoroutine(StartImageFlash());
       source = GetComponent<AudioSource>();
   }
   IEnumerator StartImageFlash()
   {
       _color = notebookImage.color;
       _checkG = false;
       var timer = 0f;
       while (!_checkG)
       {
           timer = 0;
           while (!_checkG)
           {
               timer += Time.deltaTime;
               _color.b = Mathf.Lerp(_color.b, 0, timer);
               notebookImage.color = _color;
               yield return new WaitForEndOfFrame();
               if (timer>=1f)
               {
                   break;
               }
           }
           timer = 0f;
           while (!_checkG)
           {
               timer += Time.deltaTime*2;
               _color.b = Mathf.Lerp(_color.b, 1, timer);
               notebookImage.color = _color;
               yield return new WaitForEndOfFrame();
               if (timer>=1f)
               {
                   break;
               }
           }
       }
   }
   private void Update()
   {
       if (Input.GetKeyDown(KeyCode.G))
       {
           _checkG = true;
       }
   }
   private void OnTriggerEnter(Collider other)
    {
        maxVisiblePuzzleValueIncrease();
        if (other.gameObject.name == "birinci")
        {
            source.Play();  // Görev tamamlandı ses
            Destroy(other.gameObject);
            StartCoroutine(StartImageFlash());
            nesne2.SetActive(true);
            task1.SetActive(true);
            FirstTask();

        }
        else if (other.gameObject.name == "ikinci")
        {
            source.Play(); 
            Destroy(other.gameObject);
            StartCoroutine(StartImageFlash());
            nesne3.SetActive(true);
            task2.SetActive(true);
            SecondTask();
        }
        else if (other.gameObject== nesne3)
        {
            GameManager.Manager.finish.SetActive(true);
            GameEnding.isGameFinished = true;
        }
        //todo ucuncu finish
        //todo open ui
    }
   void maxVisiblePuzzleValueIncrease()
   {
       Puzzles.maxVisiblePuzzle++;
       //Puzzles.puzzleNumber++;
   }
   void FirstTask()
   {
       StartCoroutine(WaitForSFirstStoryFinished());
   }   
   void SecondTask()
   {
       StartCoroutine(WaitForSecondStoryFinished());
   }

   void ThirTask()
   {
       StartCoroutine(WaitForThirdStoryFinished());
   }
   private IEnumerator WaitForSFirstStoryFinished()
   {
       yield return new WaitForSeconds(6);
       task1.SetActive(false);
   }   
   private IEnumerator WaitForSecondStoryFinished()
   {
       yield return new WaitForSeconds(6);
       task2.SetActive(false);
   }

   private IEnumerator WaitForThirdStoryFinished()
   {
       yield return new WaitForSeconds(10);
       
       SceneManager.LoadScene("newScenes");
   }
   

}
