using UnityEngine;
using System.Collections;

public class pointerMove : MonoBehaviour {
	private Rigidbody2D body2d;
	Vector2 newPosition;
	private float xVal,yVal,destance;
	Vector2 v,lastposition;
	public float force=200;
	void Start () {
		body2d = GetComponent<Rigidbody2D> ();
		newPosition = transform.position;
		v=new Vector2(0,0);
		lastposition = transform.position;
	}
	void Update()
	{
		if (Input.GetMouseButtonDown (0)) {
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			if (Physics.Raycast (ray, out hit)) {
				newPosition = hit.point;
				xVal = -(transform.position.x - newPosition.x);
				yVal = -(transform.position.y - newPosition.y);
				destance = Mathf.Sqrt (xVal * xVal + yVal * yVal);
				v.x = xVal / destance;
				v.y = yVal / destance;

			}
		
			xVal = transform.position.x - newPosition.x;
			yVal = transform.position.y - newPosition.y;
			Vector2 slower;
			slower.x= transform.position.x - lastposition.x;
			slower.y= transform.position.y - lastposition.y;
			//body2d.AddRelativeForce (-10*force * slower);
			body2d.AddForce (force * v);
			//body2d.AddForce (force*v);
		}
		lastposition=transform.position;
		//transform.position.x += xVal / destance;
		//transform.position.y += yVal / destance;
		//body2d.velocity = v;
	}
}
