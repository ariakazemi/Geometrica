using UnityEngine;
using System.Collections;

public class boundryBlast : MonoBehaviour {
	private GameObject player;
	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Boundry");
	}
	void Update () {
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		print (col.gameObject.name);


		if( col.gameObject.name == "DangerPoint")
		{
			print ("gave");
			Destroy (player);
		}
	}
}
