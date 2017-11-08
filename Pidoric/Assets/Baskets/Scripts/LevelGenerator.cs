using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{

    public int difficulty;
    public int maxColorsAmount;
    public float startPointX;
    public GameObject Circle;
    public GameObject Basket;
    /*public Color purple = new Color(255, 0, 230);
    public Color light_blue = new Color(20, 204, 186);
    public Color yellow = new Color(255, 210, 25);*/
    public Color[] colorScheme = new Color[4];
    int colorAmount, ballsAmount;
    float interval, positionX;
    int colorVariant;
    float wid; 

    // Use this for initialization
    void Start()
    {
        wid = startPointX * (-2);
        colorAmount = Mathf.Min((difficulty) / 2 + 2, 4);
        ballsAmount = difficulty * 2 + 1;
        interval = wid / (colorAmount-1);
        positionX = startPointX;
        for (int i = 0; i < colorAmount; i++)
        {
            Basket.transform.position = new Vector3(positionX, -4, 0);
            Basket.GetComponent<SpriteRenderer>().color = colorScheme[i];
            positionX += interval;
            Instantiate(Basket);
        }
        for (int i = 0; i < ballsAmount; i++)
        {
            colorVariant = (int)(Random.value* colorAmount);
            Circle.GetComponent<SpriteRenderer>().color = colorScheme[colorVariant];
            Circle.transform.position = Random.insideUnitCircle * 5 * Random.value;
            Instantiate(Circle);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}