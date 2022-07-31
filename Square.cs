using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Square : MonoBehaviour
{
    private Rigidbody2D rb;
    GameManager gameManager;
    public GameObject clock;
    public GameObject hourglass;
    public GameObject GGSquareR;
    public GameObject GGSquareL;
    public GameObject PSquareR;
    public GameObject GSquareL;
    public GameObject GSquareR;
    public GameObject MSquareL;
    public GameObject MSquareR;
    public GameObject PSquareL;
    public GameObject redx;
    public GameObject particle;
    public Renderer rend;
    public Color SquareColor;
    public Color red;
    public Color green;
    public Color blue;
    public float hForce = 1;
    public float vForce = -0.5f;
    public float speed;
    public int rando;
    public int item;

    void Start()
    {
        gameManager = GameManager.gameManager;
        rb = GetComponent<Rigidbody2D>();

        rend = gameObject.GetComponent<Renderer>();

        red = new Color(1, 0, 0);
        green = new Color(0, 1, 0);
        blue = new Color(0, 0, 1);

        rando = Random.Range(1, 4);

        switch (rando)
        {
            case 1:
                SquareColor = red;
                break;
            case 2:
                SquareColor = green;
                break;
            case 3:
                SquareColor = blue;
                break;
        }
        rend.material.color = SquareColor;
    }

    void Update()
    {
        transform.Translate(Vector3.right * hForce * speed * Time.deltaTime);
        transform.Translate(Vector3.down * vForce * speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.layer == 8)
        {
            hForce *= -1;
        }

        if(other.gameObject.layer == 12){
            vForce *= -1;
        }
    }

    public void OnMouseDown()
    {
        if (SquareColor == PanelColor.instance.panelColor)
        {
            switch (gameObject.tag)
            {
                case "GGSquare":
                    Instantiate(particle, gameObject.transform.position, gameObject.transform.rotation);
                    Instantiate(GSquareR, new Vector2(this.transform.position.x + 1, this.transform.position.y), this.transform.rotation);
                    Instantiate(GSquareL, new Vector2(this.transform.position.x - 1, this.transform.position.y), this.transform.rotation);

                    item = Random.Range(1, 50);
                    switch (item)
                    {
                        case 2:
                            Instantiate(clock, gameObject.transform.position, gameObject.transform.rotation);
                            break;
                        case 3:
                            Instantiate(hourglass, gameObject.transform.position, gameObject.transform.rotation);
                            break;
                    }
                    gameManager.count++;
                    Destroy(gameObject);
                    break;
                case "GSquare":
                    Instantiate(particle, gameObject.transform.position, gameObject.transform.rotation);
                    Instantiate(MSquareR, new Vector2(this.transform.position.x + 1, this.transform.position.y), this.transform.rotation);
                    Instantiate(MSquareL, new Vector2(this.transform.position.x - 1, this.transform.position.y), this.transform.rotation);

                    item = Random.Range(1, 50);
                    switch (item)
                    {
                        case 2:
                            Instantiate(clock, gameObject.transform.position, gameObject.transform.rotation);
                            break;
                        case 3:
                            Instantiate(hourglass, gameObject.transform.position, gameObject.transform.rotation);
                            break;
                    }
                    gameManager.count++;
                    Destroy(gameObject);
                    break;
                case "MSquare":
                    Instantiate(particle, gameObject.transform.position, gameObject.transform.rotation);
                    Instantiate(PSquareR, new Vector2(this.transform.position.x + 1, this.transform.position.y), this.transform.rotation);
                    Instantiate(PSquareL, new Vector2(this.transform.position.x - 1, this.transform.position.y), this.transform.rotation);

                    item = Random.Range(1, 50);
                    switch (item)
                    {
                        case 2:
                            Instantiate(clock, gameObject.transform.position, gameObject.transform.rotation);
                            break;
                        case 3:
                            Instantiate(hourglass, gameObject.transform.position, gameObject.transform.rotation);
                            break;
                    }
                    gameManager.count++;
                    Destroy(gameObject);

                    break;
                case "PSquare":
                    Instantiate(particle, gameObject.transform.position, gameObject.transform.rotation);
                    item = Random.Range(1, 50);
                    switch (item)
                    {
                        case 2:
                            Instantiate(clock, gameObject.transform.position, gameObject.transform.rotation);
                            break;
                        case 3:
                            Instantiate(hourglass, gameObject.transform.position, gameObject.transform.rotation);
                            break;
                    }
                    gameManager.count++;
                    Destroy(gameObject);
                break;
            }
        }
        else{
            gameManager.miss++;
            Instantiate(redx, gameObject.transform.position, gameObject.transform.rotation);
        }
    }
}
