using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreCounter : MonoBehaviour
{
    public static scoreCounter Instance;
    public TextMeshPro scoreText;

    int score = 0;

    private void Awake()
    {
        Instance = this; 
    }

    void Start()
    {
        scoreText.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void addPoints1()
    {
        score += 10;
        scoreText.text = score.ToString();
    }
    public void addPoints2()
    {
        score += 20;
        scoreText.text = score.ToString();
    }
    public void addPoints3()
    {
        score += 30;
        scoreText.text = score.ToString();
    }
    public void addPoints4()
    {
        score += 40;
        scoreText.text = score.ToString();
    }
    public void addPoints5()
    {
        score += 50;
        scoreText.text = score.ToString();
    }
    public void addPointsufo()
    {
        score += 100;
        scoreText.text = score.ToString();
    }



    public void subtractPoints()
    {
        score -= 10;
        scoreText.text = score.ToString();
    }
}
