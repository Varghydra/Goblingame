using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moment : MonoBehaviour {

    public Controlls controller;
  
  public float runSpeed = 40f;

  float horizontalMove = 10f;

    // Update is called once per frame
    void Update() {
   
       horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed; 
    
    }
    
    //move my character
    void FixedUpdate ()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, false);
    }
}
