using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnerDifficultyGennerator : MonoBehaviour {
    public int difficulty;
    public GameObject Square;
    public GameObject obstacle;
    public GameObject obstaclePack1;
    // Use this for initialization
    void Start ()
    {
        if (difficulty == 1) {
            obstacle.transform.position = new Vector3(Square.transform.position.x + 15, 1, 0);
            Instantiate(obstacle);

        }
        if (difficulty == 2)
        {
            obstaclePack1.transform.position = new Vector3(Square.transform.position.x + 15, 1, 0);
            Instantiate(obstaclePack1);

        }

    }
	
	// Update is called once per frame
	
}
