using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int goodAppleCount = 0;
    public int rottenAppleCount = 0;

    public int winCount = 6;
    public int loseCount = 4;

    private bool gameEnded = false;

    public void CollectGoodApple()
    {
        if (gameEnded) return;

        goodAppleCount++;

        if (goodAppleCount >= winCount)
        {
            WinGame();
        }
    }

    public void CollectRottenApple()
    {
        if (gameEnded) return;

        rottenAppleCount++;

        if (rottenAppleCount >= loseCount)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        gameEnded = true;
        SceneManager.LoadScene("GameOverScene");
    }

    void WinGame()
    {
        gameEnded = true;
        Debug.Log("YOU WIN!");
        // You can add a Win scene later
    }
}
