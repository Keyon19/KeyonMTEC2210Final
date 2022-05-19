using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreCounter : MonoBehaviour
{
    public static scoreCounter Instance;
    public TextMeshPro scoreText;

    int score = 0000;

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

    public void addPoints()
    {
        score += 10;
        scoreText.text = score.ToString();
    }
}
