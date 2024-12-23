using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicManager : MonoBehaviour
{
    public int score = 0;
    public Text scoreText ;
    public GameObject GameOverScreen;

    void Start()
    {
        GameOverScreen.SetActive(false);
    }

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = score.ToString();
    }

    public void resetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        GameOverScreen.SetActive(true);
    }
}
