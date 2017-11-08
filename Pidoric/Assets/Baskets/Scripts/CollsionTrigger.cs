using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollsionTrigger : MonoBehaviour {

    public GameObject basket;
    public float offset;

    void OnTriggerStay2D(Collider2D coll)
    {
        if ((coll.gameObject.GetComponent<SpriteRenderer>().color == basket.GetComponent<SpriteRenderer>().color) && (Vector3.Distance(coll.gameObject.transform.position, basket.transform.position)) <= offset)
        {
            //Debug.Log(Vector3.Distance(coll.gameObject.transform.position, basket.transform.position));
            Destroy(coll.gameObject);
        }

    }
}
