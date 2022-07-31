using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TNT : MonoBehaviour
{
    private bool isDragging;
    public GameObject explosion;
    public int count;
    void Start()
    {
        Destroy(gameObject, 5f);
    }

    void OnMouseDown(){
        Instantiate(explosion, gameObject.transform.position, gameObject.transform.rotation);
        Destroy(gameObject);
    }

    void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.layer == 9){
            Instantiate(explosion, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(gameObject);
        }
    }
}
