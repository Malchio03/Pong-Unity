using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // singelton pattern
    public static GameManager instance;

    public int scorePlayer1;
    public int scorePlayer2;
    public ScoreText scoreTextPlayer1;
    public ScoreText scoreTextPlayer2;
    public Action onReset;

    private void Awake()
    {
        if (instance)
        {
            Destroy(gameObject);
        } else
        {
            instance = this;
        }
    }

    public void OnScoreZoneReached(int id)      // id it's for the score zone
    {
        if(onReset != null)
            onReset.Invoke();

        if (id == 1)
            scorePlayer1++;

        if(id == 2)
            scorePlayer2++;

        UpdateScores();
        HighLightScore(id);
    }

    private void UpdateScores()
    {
        scoreTextPlayer1.SetScore(scorePlayer1);
        scoreTextPlayer2.SetScore(scorePlayer2);
    }

    public void HighLightScore(int id)
    {
        if(id == 1)
            scoreTextPlayer1.HighLight();

        if(id == 2)
            scoreTextPlayer2.HighLight();
    }
}
