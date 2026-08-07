using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int scorePlayer1;
    public int scorePlayer2;
    public ScoreText scoreTextPlayer1;
    public ScoreText scoreTextPlayer2;

    public void OnScoreZoneReached(int id)      // id it's for the score zone
    {
        if (id == 1)
            scorePlayer1++;

        if(id == 2)
            scorePlayer2++;

        UpdateScores();
    }

    private void UpdateScores()
    {
        scoreTextPlayer1.SetScore(scorePlayer1);
        scoreTextPlayer2.SetScore(scorePlayer2);
    }
}
