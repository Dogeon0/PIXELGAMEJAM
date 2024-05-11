using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimeHandler : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    private float timer = 0f;

    void Update()
    {
        // Increase timer by Time.deltaTime each frame
        timer += Time.deltaTime;

        // Convert timer to minutes and seconds
        int minutes = Mathf.FloorToInt(timer / 60f);
        int seconds = Mathf.FloorToInt(timer % 60f);

        // Update the timer text
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
