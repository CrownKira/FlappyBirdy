using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

  // public to expose to other classes; eg. the "ui interface" can then access these and do something to it;
  public Rigidbody2D myRigidbody;
  public float flapStrength;



  // run precisely once 
  // Start is called before the first frame update
  void Start()
  {
    gameObject.name = "Bob birdington";
  }

  // every single frame 
  // Update is called once per frame
  void Update()
  {
    if (Input.GetKeyDown(KeyCode.Space) == true)
    {
      myRigidbody.velocity = Vector2.up * flapStrength;
    }
  }
}











