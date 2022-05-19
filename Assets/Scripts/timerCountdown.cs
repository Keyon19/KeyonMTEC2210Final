using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class timerCountdown : MonoBehaviour
{

    public float timeValue = 90;
    public TextMeshPro timeText;
    void Start()
    {
        
    }


    void Update()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        } else
        {
            timeValue = 0;
            SceneManager.LoadScene("mainScene");

        }

        displayTime(timeValue);
    }

    void displayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
