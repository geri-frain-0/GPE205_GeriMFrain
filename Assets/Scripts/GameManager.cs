using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
   
    private Rigidbody rb;
    Rigidbody rigidbody;
    Vector3 moveVector;
    public float speed;
    public string theText = "Ship Deck";
    // Start is called before the first frame update
  
    public float moveSpeed;
    // Variable for turn speed
    public float turnSpeed;
    public ShipPawn pawn;
    private Transform tf;
    
    void Start()
    {
        Debug.Log(theText);
        rb = GetComponent<Rigidbody>();
        rigidbody = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Move up every frame draw by adding 1 to the y of our position
        transform.position = transform.position + (Vector3.forward * speed);
        transform.position = transform.position + (Vector3.right * speed);
        Vector3 myVector = new Vector3(2, 4, 12);
        myVector = myVector.normalized; // You could also call the function myVector.Normalize();
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);               
        rb.AddForce(movement * speed);
        tf.Rotate(0, turnSpeed, 0);
    }

}
