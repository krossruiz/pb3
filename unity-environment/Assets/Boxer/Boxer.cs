using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxer : MonoBehaviour {

    public BoxerMovement boxer_movement;
    public BoxerListener boxer_listener;

	// Use this for initialization
	void Start () {
        boxer_movement = this.GetComponent<BoxerMovement>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
