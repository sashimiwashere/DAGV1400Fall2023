using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Security.Cryptography; // Text mesh pro name space added to access the library for UI

public class ScoreManager : MonoBehaviour
{
    public int score; // Keep our score value
    public TextMeshProUGUI scoreText; //Visual text element to be modified
    public void IncreaseScore(int amount) // When called increases the score by a predetermied amount set in score variable
    {
        score += amount;
        UpdateScoreText();
    }
    public void DecreaseScore(int amount) // When caaled decreases the score by a predetermied amount set in score variable
    {
        score -= amount;
        UpdateScoreText();
    }

    public void UpdateScoreText() // updates the score in the HUD UI text
    {
        scoreText.text = "Score: "+ score;
    }
}
