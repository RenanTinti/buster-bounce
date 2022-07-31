using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 5f);
    }

    void Update()
    {

    }

    void OnMouseDown()
    {
        StartCoroutine(Pause());
    }

    IEnumerator Pause() {
        Time.timeScale = 0f;
        yield return new WaitForSecondsRealtime(5f);
        Time.timeScale = 1f;
        Destroy(gameObject);

    }
}
