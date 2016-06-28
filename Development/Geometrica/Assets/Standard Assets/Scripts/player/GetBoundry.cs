using UnityEngine;
using System.Collections;

public class GetBoundry : MonoBehaviour {
	public float lonlySoul;
	//public static float lowM;
	private GameObject Core;
	public ParticleSystem particle;
	void Start () {
		Core = GameObject.Find ("Core");
		particle = Core.GetComponent<ParticleSystem>();
	}
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter2D (Collision2D col)
	{


		if( col.gameObject.tag == "CircleBoundry")
		{
			GameObject boundry =GameObject.Find( col.gameObject.name);
			transform.position = boundry.transform.position;
			boundry.tag="ActiveBoundry";
			boundry.GetComponent<SpriteRenderer> ().color = new Color(1.0f,1.0f,1.0f,1.0f) ;
			particle.Stop();
			Core.GetComponent<Rigidbody2D> ().mass = Core.GetComponent<Rigidbody2D> ().mass*lonlySoul;
			Core.GetComponent<pointerMove> ().force = Core.GetComponent<pointerMove> ().force * lonlySoul;
		}
	}
}
