using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class ScoreText : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    public void SetScore(int value)
    {
        scoreText.text = value.ToString();
    }
}
