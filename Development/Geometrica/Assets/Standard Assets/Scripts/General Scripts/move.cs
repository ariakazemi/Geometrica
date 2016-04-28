using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
	private Rigidbody2D body2d;

	public static float speed = 1.0f;
	// Use this for initialization
	void Awake () {
		body2d = GetComponent<Rigidbody2D> ();
	}

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 v = new Vector2(0,0);
		if (Input.GetKey (KeyCode.W)) {
			v.y = speed;
		}
		if (Input.GetKey (KeyCode.S)) {
			v.y = -speed;
		}
		if (Input.GetKey (KeyCode.A)) {
			v.x = -speed;
		}
		if (Input.GetKey (KeyCode.D)) {
			v.x = speed;
		}
		body2d.velocity = v;

	}
}
