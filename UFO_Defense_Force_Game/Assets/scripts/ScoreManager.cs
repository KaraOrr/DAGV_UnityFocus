using UnityEngine;
using TMPro; //Text Mesh Pro namespace added to access the unity library's for UI

public class ScoreManager : MonoBehaviour
{
    public int score; //keep our score value
    public TextMeshProUGUI scoreText; //Visual text element to be modified
    public void IncreaseScore(int amount) //this method when called increases the score by a predetermined amount set in score variable
    {
        score += amount;
        UpdateScoreText();
    }

    public void DecreaseScore(int amount) //This method when called decreases the score by a predetermined amount set in score variable
    {
        score -= amount;
        UpdateScoreText();
    }

    public void UpdateScoreText() //This method updates the score in the HUD UI Text
    {
        scoreText.text = "Score: "+ score;
    }
}