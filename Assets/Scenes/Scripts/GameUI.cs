using UnityEngine;

public class GameUI : MonoBehaviour
{
    public ScoreText scoreTextPlayer1, scoreTextPlayer2;
    public GameObject menuObject;

    public System.Action onStartGame;

    public void UpdateScores(int scorePlayer1, int scorePlayer2)
    {
        scoreTextPlayer1.SetScore(scorePlayer1);
        scoreTextPlayer2.SetScore(scorePlayer2);
    }


    public void OnStartGameButtonClicked()
    {
        menuObject.SetActive(false);
        onStartGame?.Invoke();
    }

}
