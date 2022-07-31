/*
    GG - 15
    G - 7
    M - 3
    P - 1
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    public GameObject finishPanel;
    public GameObject timeOut;
    public GameObject star1;
    public GameObject star2;
    public GameObject star3;
    public GameObject next;
    public GameObject retry;
    public GameObject quit;
    public int goalCount;
    public int count = 0;
    public int miss = 0;
    public Text timeValue;
    public float time;
    public float points;

    void Awake(){
        if(gameManager == null){
            gameManager = this;
        }
        else{
            Destroy(gameObject);
        }
    }

    void Update()
    {
        print(count);

        if(time > 0){
            time -= Time.deltaTime;
        }
        else{
            time = 0;
        }
        timeValue.text = time.ToString("00");

        if(time <= 0){
            finishPanel.SetActive(true);
            timeOut.SetActive(true);
            retry.SetActive(true);
            quit.SetActive(true);
            Time.timeScale = 0f;
        }

        if(count >= goalCount && time >= 30 && miss == 0){
            finishPanel.SetActive(true);
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
            next.SetActive(true);
            retry.SetActive(true);
            quit.SetActive(true);
            Time.timeScale = 0f;
        }

        else if(count >= goalCount && time >= 30 && miss > 0){
            finishPanel.SetActive(true);
            star1.SetActive(true);
            star2.SetActive(true);
            next.SetActive(true);
            retry.SetActive(true);
            quit.SetActive(true);
            Time.timeScale = 0f;
        }
        else if(count >= goalCount && time >= 20){
            finishPanel.SetActive(true);
            star1.SetActive(true);
            star2.SetActive(true);
            next.SetActive(true);
            retry.SetActive(true);
            quit.SetActive(true);
            Time.timeScale = 0f;
        }
        else if(count >= goalCount && time < 20){
            finishPanel.SetActive(true);
            star1.SetActive(true);
            next.SetActive(true);
            retry.SetActive(true);
            quit.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void Next(){
        SceneManager.LoadScene("")
    }

    public void Retry(){

    }

    public void Quit(){

    }
}
