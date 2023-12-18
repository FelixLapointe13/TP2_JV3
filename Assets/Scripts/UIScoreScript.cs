using TMPro;
using UnityEngine;

public class UIScoreScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public LevelManager levelManager; // Assurez-vous de l'assigner dans l'Inspector Unity

    private int score = 0;
    private const int maxScore = 3; // Score maximum à atteindre

    private void Start()
    {
        UpdateScoreText();
    }

    public void IncreaseScore()
    {
        if (score < maxScore)
        {
            score++;
            UpdateScoreText();

            if (score == maxScore)
            {
                // Appeler la méthode sur LevelManager lorsque le score atteint 3
                if (levelManager != null)
                {
                    levelManager.LevelCompleted();
                }
            }
        }
    }

    public void DecreaseScore()
    {
        if (score > 0)
        {
            score--;
            UpdateScoreText();
        }
    }

    private void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score + "/" + maxScore;
        }
    }
}
