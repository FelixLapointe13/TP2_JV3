using TMPro;
using UnityEngine;

public class UIScoreScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    private int score = 0;

    public void IncreaseScore()
    {
        score++;
        UpdateScoreText();
    }

    public void DecreaseScore()
    {
        score--;
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();
        }
    }
}
