using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
	private Rigidbody2D body2d;
	bool left,rigth,up,down;
	public static float speed = 1.0f;
	public static float maxSpeed = 3.0f;
	public static float Acc=0.1f;
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



		if (Input.GetKey (KeyCode.W)) {
			if (!up) {
				up = true;
				down = rigth = left = false;
				speed = 1.0f;
			} else {
				if (speed < maxSpeed)
					speed += Acc;

			}
			v.y = speed;
		}
		if (Input.GetKey (KeyCode.S)) {
			if (!down) {
				down = true;
				up = rigth = left = false;
				speed = 1.0f;
			} else {
				if (speed < maxSpeed)
					speed += Acc;
			}
			v.y = -speed;
		}
		if (Input.GetKey (KeyCode.A)) {
			if (!left) {
				left = true;
				up = rigth = down = false;
				speed = 1.0f;
			} else {
				if (speed < maxSpeed)
					speed += Acc;
			}
			v.x = -speed;
		}
		if (Input.GetKey (KeyCode.D)) {
			if (!rigth) {
				rigth = true;
				up = left = down = false;
				speed = 1.0f;
			} else {
				if (speed < maxSpeed)
					speed += Acc;
			}
			v.x = speed;
		}
		body2d.velocity = v;

	}
}
