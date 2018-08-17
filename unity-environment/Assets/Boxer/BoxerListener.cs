using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxerListener
{

    public Boxer boxer;

    public KeyCode move_left_key;
    public KeyCode move_right_key;
    public KeyCode punch_key;
    public KeyCode jump_key;

    public BoxerListener(
        Boxer boxer,
        KeyCode move_left_key,
        KeyCode move_right_key,
        KeyCode punch_key,
        KeyCode jump_key
    )
    {
        this.boxer = boxer;
        this.move_left_key = move_left_key;
        this.move_right_key = move_right_key;
        this.punch_key = punch_key;
        this.jump_key = jump_key;
    }

    public void listen()
    {
        if (Input.GetKey(move_left_key)) { boxer.boxer_movement.request_left_key_action(); }
        if (Input.GetKey(move_right_key)) { boxer.boxer_movement.request_right_key_action(); }
        if (Input.GetKeyDown(punch_key)) { boxer.boxer_movement.request_punch_key_action(); }
        if (Input.GetKeyDown(jump_key)) { boxer.boxer_movement.request_jump_key_action(); }
    }
}
