﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.layer == 9){
            Destroy(other.gameObject);
        }
    }   
}
