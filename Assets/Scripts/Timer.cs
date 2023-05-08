using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 60f;  // Starting time in seconds
    public Text timeText;              // UI Text element to display time

    void Update()
    {
        timeRemaining -= Time.deltaTime;  // Decrement time remaining by elapsed time

        if (timeRemaining <= 0f)
        {
            // Load GAME OVER scene
            SceneManager.LoadScene("GameOver");
        }

        // Convert remaining time to minutes and seconds
        int minutes = Mathf.FloorToInt(timeRemaining / 60f);
        int seconds = Mathf.FloorToInt(timeRemaining % 60f);

        // Update time text element
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}

