using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

interface charcter_listener {
    void move_left();
    void move_right();
    void punch();
    void jump();
}

public class InputMaster : MonoBehaviour {

    public SceneMaster sm;

	// Use this for initialization
	void Start () {
        
    }

    List<BoxerListener> boxer_listeners = new List<BoxerListener>();

    public void add_boxer_listener(BoxerListener boxer_listener) {
        boxer_listeners.Add(boxer_listener);
    }
	
	// Update is called once per frame
	void Update () {
        for (int i = 0; i < sm.boxers.Count; i++) {
            sm.boxers[i].GetComponent<Boxer>().boxer_listener.listen();
        }
	}

    public BoxerListener create_boxer_wasd_listener(Boxer boxer) {
        BoxerListener wasd_listener = new BoxerListener(
            boxer,
            KeyCode.A,
            KeyCode.D,
            KeyCode.E,
            KeyCode.LeftShift
        );
        return wasd_listener;
    }

    public BoxerListener create_boxer_arrows_listener(Boxer boxer)
    {
        BoxerListener arrows_listener = new BoxerListener(
            boxer,
            KeyCode.LeftArrow,
            KeyCode.RightArrow,
            KeyCode.Return,
            KeyCode.RightShift    
        );
        return arrows_listener;
    }

}