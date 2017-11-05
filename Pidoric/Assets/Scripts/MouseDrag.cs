using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag : MonoBehaviour {
    public  GameObject circle;
    Vector3 offset;
    
    bool pressed = false;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        if (Input.GetMouseButtonDown(0) && (circle.GetComponent<CircleCollider2D>().bounds.Contains(mousePos))) {
            pressed = true;
            offset = mousePos - circle.transform.position;
        }
        //circle.GetComponent<CircleCollider2D>().radius = 2;
        Vector3 circlePos = circle.transform.position;
        if (Input.GetMouseButton(0) && pressed)
        {
            //circle.GetComponent<CircleCollider2D>().radius = 200;
            circle.transform.position = mousePos - offset;
            //Debug.Log(pressed);
        }
        else
        {
            circle.GetComponent<CircleCollider2D>().radius = 0.5f;
        }

        if (Input.GetMouseButtonUp(0))
        {
            pressed = false;
        }
		
	}
}
