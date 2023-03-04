using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

  // public to expose to other classes; eg. the "ui interface" can then access these and do something to it;
  public Rigidbody2D myRigidbody;
  public float flapStrength;
  public LogicScript logic;
  public bool birdIsAlive = true;

  // run precisely once 
  // Start is called before the first frame update
  void Start()
  {
    // gameObject.name = "Bob birdington";
    logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
  }

  // every single frame 
  // Update is called once per frame
  void Update()
  {

    if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
    {
      myRigidbody.velocity = Vector2.up * flapStrength;
    }
  }

  private void OnCollisionEnter2D(Collision2D collision)
  {
    logic.gameOver();
    birdIsAlive = false;
  }
}
