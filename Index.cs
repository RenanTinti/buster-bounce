using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Index : MonoBehaviour
{
    public void BeginGame(){
        SceneManager.LoadScene("PhasePanel");
    }

    public void ExitGame(){
        Application.Quit();
    }
}
