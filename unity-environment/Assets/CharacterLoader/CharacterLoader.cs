using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterLoader : MonoBehaviour {

    public List<GameObject> boxer_prefabs = new List<GameObject>();
    public SceneMaster sm;

    // Use this for initialization
    void Start()
    {
        copy_boxers_to_scene_master();
    }

    void copy_boxers_to_scene_master() {
        sm.boxer_prefabs = this.boxer_prefabs;
        sm.boxers_quick_input_setup();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
