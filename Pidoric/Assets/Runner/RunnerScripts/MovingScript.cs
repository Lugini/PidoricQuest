using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingScript : MonoBehaviour {
    private bool grounded = false;
    public Rigidbody2D Cube;
    public float thrust;    // Use this for initialization
                            //private bool grounded;
    void OnCollisionEnter2D(Collision2D coll)
    {
        grounded = true;
    }
    void OnCollisionExit2D(Collision2D coll)
    {
        grounded = false;
    }
    // Update is called once per frame
    void Update ()
    {
            Cube.AddForce(transform.right * thrust);

       
            if (Input.GetMouseButtonDown(0)&&grounded) {
                Cube.AddForce(transform.up * 400);

            }
        
    }
}
