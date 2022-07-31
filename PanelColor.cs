using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelColor : MonoBehaviour
{
    public static PanelColor instance;
    public Image rend;
    public Color panelColor;
    public Color red;
    public Color green;
    public Color blue;   
    public int rando;
    
    void Awake(){
        if(instance == null){
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else{
            Destroy(gameObject);
        }
    }
    void Start()
    {
        rend = gameObject.GetComponent<Image>();
        red = new Color(1, 0, 0);
        green = new Color(0, 1, 0);
        blue = new Color(0, 0, 1);

        rando = Random.Range(1, 4);
        switch(rando){
            case 1:
                panelColor = red;
            break;
            case 2:
                panelColor = green;
            break;
            case 3:
                panelColor = blue;
            break;
            default:
                panelColor = Color.white;
            break;
        }

        rend.material.color = panelColor;
    }

    public void ChangeColor(){
        if(panelColor == red){
            panelColor = green;
            rend.material.color = panelColor;
        }
        else if(panelColor == green){
            panelColor = blue;
            rend.material.color = panelColor;
        }
        else if(panelColor == blue){
            panelColor = red;
            rend.material.color = panelColor;
        }
    }
}
