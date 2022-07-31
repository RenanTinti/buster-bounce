using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Remove : MonoBehaviour
{
    public float destime;

    void Start()
    {
        Destroy(gameObject, destime);    
    }
}
