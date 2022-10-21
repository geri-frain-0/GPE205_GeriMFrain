using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShipPawn : Pawn
{
    
    public float speed;
    private Transform tf;

  

    // Start is called before the first frame update
    public override void Start()
    {  
        base.Start();
        
}

    // Update is called once per frame
    // Update is called once per frame
    public override void Update()
    {
        Transform tf = GetComponent<Transform>(); // Get the Transform component from the object as this code is on

        base.Start();
       
        Vector3 myVector = new Vector3(2, -2, 27); // Create a vector 2 units on x, -2 units on y, and 27 on z
        
                                       // Move up every frame draw by adding 1 to the y of our position

    }

    public override void MoveForward()
    {
        Debug.Log("Move Forward");
      
    }

    public override void MoveBackward()
    {
        Debug.Log("Move Backward");
       
    }

    public override void RotateClockwise()
    {
        Debug.Log("Rotate Clockwise");
        tf.position = tf.position + Vector3.right;
   

    }

    public override void RotateCounterClockwise()
    {
        Transform tf = GetComponent<Transform>();
        Debug.Log("Rotate Counter-Clockwise");
        tf.position = tf.position + (Vector3.up * 0.5f);
       
    }

    public void Pulse(int numberOfPulses)
    // TODO Make a for loop to do something "number of pulses times"
    {
        Vector2 myVector = new Vector2(2, -2); // Create a vector 2 units on x, and -2 units on y
        
        // TODO: Actually make this pulse once
        {
            Transform tf = GetComponent<Transform>();
            // Vector3.up is a preset Vector of (0,1,0)
            
            // There is also a Vector3.right (1,0,0) and Vector3.forward (0,0,1)
            tf.position = tf.position + (Vector3.up * 0.5f);
        }
    }
}