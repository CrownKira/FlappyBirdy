using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
  public int playerScore;
  public Text scoreText;
  public GameObject gameOverScreen;

  // make the function more versatile; keep it open for future ideas; make it less rigid;
  [ContextMenu("Increase Score")]
  public void addScore(int scoreToAdd)
  {
    playerScore += scoreToAdd;
    scoreText.text = playerScore.ToString();
  }

  public void restartGame()
  {
    // look for name of the scene
    // here can just put current scene
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);

  }

  public void gameOver()
  {
    gameOverScreen.SetActive(true);
  }

}
