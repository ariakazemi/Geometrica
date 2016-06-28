using UnityEngine;
using System.Collections;

public class boundryBlast : MonoBehaviour {
	//private GameObject player;
	private GameObject Core;
	public ParticleSystem particle;
	// Use this for initialization
	void Start () {
		//player = GameObject.;
		Core = GameObject.Find ("Core");
		particle = Core.GetComponent<ParticleSystem>();
	}


	void Update () {
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		


		if( col.gameObject.name == "DangerPoint")
		{
			
			Destroy (gameObject);
			particle.Play();
		}
	}
}
