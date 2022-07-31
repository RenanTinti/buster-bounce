using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ball;
    public GameObject anotherBall;

    void Start()
    {
        Invoke("SpawnBall", 1.5f);
        Invoke("SpawnAnotherBall", 2.5f);
    }

    private void SpawnBall(){
        Instantiate(ball, gameObject.transform.position, gameObject.transform.rotation);
        Invoke("SpawnBall", 2f);
    }

    private void SpawnAnotherBall(){
        Instantiate(anotherBall, gameObject.transform.position, gameObject.transform.rotation);
        Invoke("SpawnAnotherBall", 1.5f);
    }
}
