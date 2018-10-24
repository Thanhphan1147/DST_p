using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Direct_player_cam : MonoBehaviour {
	// Use this for initialization
	void Start ()
    {
        //transform.position = new Vector3(21, 0, 0);
    }
    void Update ()
    {
        int dx = 1;
        transform.position += Vector3.right * dx;
    }
}
