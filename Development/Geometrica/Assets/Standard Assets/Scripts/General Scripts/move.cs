using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
	private Rigidbody2D body2d;
	bool left,rigth,up,down;
	public static float speed = 0.5f;
	public static float maxSpeed = 3.0f;
	public static float Acc=0.05f;
	public static float friction=50;
	// Use this for initialization
	void Awake () {
		left = rigth = up = down = false;
		body2d = GetComponent<Rigidbody2D> ();
	}

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 v = new Vector2(0,0);

		if (!Input.GetKey (KeyCode.W) && !Input.GetKey (KeyCode.S) && !Input.GetKey (KeyCode.A) && !Input.GetKey (KeyCode.D)) {
			speed = speed - speed / friction;

			if (up)
				v.y = speed;
			if (down)
				v.y = -speed;
			if (left)
				v.x = -speed;
			if (rigth)
				v.x = speed;
			
		} else {
			if (!Input.GetKey (KeyCode.W))
				up = false;
			if (!Input.GetKey (KeyCode.S))
				down = false;
			if (!Input.GetKey (KeyCode.A))
				left = false;
			if (!Input.GetKey (KeyCode.D))
				rigth = false;
		}

		if (Input.GetKey (KeyCode.W)) {
			up = true;
			if (speed < maxSpeed)
				speed += Acc;
			v.y = speed;
		}
		if (Input.GetKey (KeyCode.S)) {
			down = true;
			if (speed < maxSpeed && !up)
				speed += Acc;
			v.y = -speed;
		}
		if (Input.GetKey (KeyCode.A)) {
			left = true;
			if (speed < maxSpeed && !up && !down)
				speed += Acc;
			v.x = -speed;
		}
		if (Input.GetKey (KeyCode.D)) {
			
			rigth = true;
			if (speed < maxSpeed && !up && !down && !left)
				speed += Acc;
			v.x = speed;
		}
		body2d.velocity = v;

	}
}
