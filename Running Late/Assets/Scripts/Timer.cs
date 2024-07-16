using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float timeRemaining;
    public GameManager gameManager;
    int min;
    int sec;

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else if (timeRemaining < 0)
        {
            timeRemaining = 0;
            gameManager.gameOver();
            timerText.color = Color.red;
        }
        timeRemaining -= Time.deltaTime;
        min = Mathf.FloorToInt(timeRemaining / 60);
        sec = Mathf.FloorToInt(timeRemaining % 60);
        timerText.text = string.Format("Timer: {0:00}:{1:00}", min, sec);
    }
}
