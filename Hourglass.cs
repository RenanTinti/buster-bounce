using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hourglass : MonoBehaviour
{
    
    void Start()
    {
        Destroy(gameObject, 5f);
    }

    void OnMouseDown(){
        StartCoroutine(HourglassTime());
    }

    IEnumerator HourglassTime(){
        Time.timeScale = 0.5f;
        yield return new WaitForSecondsRealtime(3f);
        Time.timeScale = 1f;
        Destroy(gameObject);
    }
}
