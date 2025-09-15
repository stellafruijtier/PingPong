using UnityEngine;
using TMPro;

public class GameUI : MonoBehaviour
{
    public ScoreText scoreTextPlayer1, scoreTextPlayer2;
    public GameObject menuObject;
    public TextMeshProUGUI winText;

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


    public void OnGameEnds(int winnerId)
    {
        menuObject.SetActive(true);
        winText.text = $"Player {winnerId} wins!";
    }

}
