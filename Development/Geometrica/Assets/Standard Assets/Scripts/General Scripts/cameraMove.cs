using UnityEngine;
using System.Collections;

public class cameraMove : MonoBehaviour {
	private Transform player;
	private Rigidbody2D body2d;
	private float speed=0.01f;
	private Transform background;
	//public Camera camera;
	// Use this for initialization
	Vector2 v,LastPlayerPos,NextPlayerpos;

	void Start () {
		body2d = GetComponent<Rigidbody2D> ();
		player = GameObject.Find ("Player").transform;
		background = GameObject.Find ("Background").transform;
		LastPlayerPos = player.position;
		v=new Vector2(0,0);
	
	}


	// Update is called once per frame
	void Update () {
		//player.
		NextPlayerpos = player.position;
		//SleepTimeout (0.1);
		Vector3 camera =transform.position;
		//playerpos.z = transform.position.z;
		/*if (NextPlayerpos.x - transform.position.x > 0.5 )
			v.x = 1;
		if (NextPlayerpos.x - transform.position.x < -0.5)
			v.x = -1;
		if (NextPlayerpos.y - transform.position.y > 0.5 )
			v.y = 1;
		if (NextPlayerpos.y - transform.position.y < -0.5)
			v.y = -1;
		*/

		if (NextPlayerpos.x - transform.position.x > 0.5 || NextPlayerpos.x - transform.position.x < -0.5 || NextPlayerpos.y - transform.position.y > 0.5 || NextPlayerpos.y - transform.position.y < -0.5) {
			camera.x += -(LastPlayerPos.x - NextPlayerpos.x);
			camera.y += -(LastPlayerPos.y - NextPlayerpos.y);
		}
		if (background.position.x - camera.x > 4.35 || background.position.x - camera.x < -4.35 ){
			camera.x=transform.position.x;
		}
		/*if (background.position.y - camera.y > 3.02 || background.position.y - camera.y < -3.02 ){
			camera.y=transform.position.y;
		}*/
		//print (Screen.width);
		transform.position = camera;

		LastPlayerPos = player.position;
	}
}
