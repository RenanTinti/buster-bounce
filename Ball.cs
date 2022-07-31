using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb;
    GameManager gameManager;
    public GameObject clock;
    public GameObject hourglass;
    public GameObject GGBallR;
    public GameObject GGBallL;
    public GameObject PBallR;
    public GameObject GBallL;
    public GameObject GBallR;
    public GameObject MBallL;
    public GameObject MBallR;
    public GameObject PBallL;
    public GameObject redx;
    public GameObject particle;
    public Renderer rend;
    public Color ballColor;
    public Color red;
    public Color green;
    public Color blue;
    public float hForce = 1;
    public float speed;
    public int rando;
    public int item;

    void Start()
    {
        gameManager = GameManager.gameManager;
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.down * 1, ForceMode2D.Impulse);

        rend = gameObject.GetComponent<Renderer>();

        red = new Color(1, 0, 0);
        green = new Color(0, 1, 0);
        blue = new Color(0, 0, 1);

        rando = Random.Range(1, 4);

        switch (rando)
        {
            case 1:
                ballColor = red;
                break;
            case 2:
                ballColor = green;
                break;
            case 3:
                ballColor = blue;
                break;
        }
        rend.material.color = ballColor;
    }

    void Update()
    {
        transform.Translate(Vector3.right * hForce * speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.layer == 8)
        {
            hForce *= -1;
        }
    }

    public void OnMouseDown()
    {
        if (ballColor == PanelColor.instance.panelColor)
        {
            switch (gameObject.tag)
            {
                case "GGBall":
                    Instantiate(particle, gameObject.transform.position, gameObject.transform.rotation);
                    Instantiate(GBallR, new Vector2(this.transform.position.x + 1, this.transform.position.y), this.transform.rotation);
                    Instantiate(GBallL, new Vector2(this.transform.position.x - 1, this.transform.position.y), this.transform.rotation);

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
                case "GBall":
                    Instantiate(particle, gameObject.transform.position, gameObject.transform.rotation);
                    Instantiate(MBallR, new Vector2(this.transform.position.x + 1, this.transform.position.y), this.transform.rotation);
                    Instantiate(MBallL, new Vector2(this.transform.position.x - 1, this.transform.position.y), this.transform.rotation);

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
                case "MBall":
                    Instantiate(particle, gameObject.transform.position, gameObject.transform.rotation);
                    Instantiate(PBallR, new Vector2(this.transform.position.x + 1, this.transform.position.y), this.transform.rotation);
                    Instantiate(PBallL, new Vector2(this.transform.position.x - 1, this.transform.position.y), this.transform.rotation);

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
                case "PBall":
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
