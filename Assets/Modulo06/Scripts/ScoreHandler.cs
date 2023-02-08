using TMPro;
using UnityEngine;

public class ScoreHandler : MonoBehaviour
{
    private int score = 0;
    public string scoreText = "Your score is: ";
    private TMP_Text textField;

    private void Awake()
    {
        textField = GetComponent<TMP_Text>();
        textField.text = scoreText + score;
    }
    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        textField.text = scoreText + score;
    }
}
