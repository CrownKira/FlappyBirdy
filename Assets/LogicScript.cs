using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
  public int playerScore;
  public Text scoreText;

  // make the function more versatile; keep it open for future ideas; make it less rigid;
  [ContextMenu("Increase Score")]
  public void addScore(int scoreToAdd)
  {
    playerScore += scoreToAdd;
    scoreText.text = playerScore.ToString();
  }

}
