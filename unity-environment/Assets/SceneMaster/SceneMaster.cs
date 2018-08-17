using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneMaster : MonoBehaviour {

    public List<GameObject> boxer_prefabs = new List<GameObject>();
    public List<GameObject> boxers = new List<GameObject>();
    public InputMaster input_master;

    public Transform spawner_location_1;
    public Transform spawn_location_2;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void boxers_quick_input_setup() {

        boxers.Add(Instantiate(boxer_prefabs[0], spawner_location_1.position, Quaternion.identity));
        boxers.Add(Instantiate(boxer_prefabs[1], spawn_location_2.position, Quaternion.identity));

        Boxer wasd_boxer = boxers[0].GetComponent<Boxer>();
        Boxer arrows_boxer = boxers[1].GetComponent<Boxer>();
        BoxerListener wasd_listener = input_master.create_boxer_wasd_listener(wasd_boxer);
        BoxerListener arrows_listener = input_master.create_boxer_arrows_listener(arrows_boxer);
        wasd_boxer.boxer_listener = wasd_listener;
        arrows_boxer.boxer_listener = arrows_listener;
    }
}
