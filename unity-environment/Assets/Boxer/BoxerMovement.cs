using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxerMovement : MonoBehaviour {

    private Rigidbody rb;
    public float run_magnitude = 10.0f;
    public float jump_magnitude = 10.0f;

    private Bounds root_collider_bounds;

	// Use this for initialization
	void Start () {
        rb = this.GetComponent<Rigidbody>();
        root_collider_bounds = this.GetComponent<BoxCollider>().bounds;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void jump() { rb.velocity = new Vector3(0, jump_magnitude, 0); }
    public void move_left() { rb.AddForce(Vector3.left * run_magnitude); }
    public void move_right() { rb.AddForce(Vector3.right * run_magnitude); }
    public void punch() { throw new NotImplementedException(); }

    public void request_jump_key_action()
    {
        jump();
    }

    public void request_left_key_action()
    {
        Vector3 max_y_max_x_center_z_world = this.gameObject.transform.position + new Vector3(root_collider_bounds.extents.x, root_collider_bounds.extents.y, 0);
        Vector3 max_y_min_x_center_z_world = this.gameObject.transform.position + new Vector3(-1 * root_collider_bounds.extents.x, root_collider_bounds.extents.y, 0);

        Vector3 left_ray_origin = max_y_min_x_center_z_world + Vector3.left * 0.05f;
        Ray left_side_ray = new Ray(left_ray_origin, Vector3.down);
        Debug.DrawRay(left_ray_origin, Vector3.down * root_collider_bounds.size.y * 0.9f, Color.red);
        if (Physics.Raycast(left_side_ray, root_collider_bounds.size.y * 0.9f)) {
            Debug.Log("Left ray intersection detected");
        }

        move_left();
    }

    public void request_right_key_action()
    {
        Vector3 max_y_max_x_center_z_world = this.gameObject.transform.position + new Vector3(root_collider_bounds.extents.x, root_collider_bounds.extents.y, 0);
        Vector3 max_y_min_x_center_z_world = this.gameObject.transform.position + new Vector3(-1 * root_collider_bounds.extents.x, root_collider_bounds.extents.y, 0);

        Vector3 right_ray_origin = max_y_max_x_center_z_world + Vector3.right * 0.05f;
        Ray right_side_ray = new Ray(right_ray_origin, Vector3.down);
        Debug.DrawRay(right_ray_origin, Vector3.down * root_collider_bounds.size.y * 0.9f, Color.red);
        if (Physics.Raycast(right_side_ray, root_collider_bounds.size.y * 0.9f))
        {
            Debug.Log("Right ray intersection detected");
        }

        move_right();
    }

    public void request_punch_key_action()
    {
        punch();
    }
}
