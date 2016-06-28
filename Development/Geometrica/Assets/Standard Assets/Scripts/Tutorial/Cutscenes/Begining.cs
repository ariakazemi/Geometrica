using UnityEngine;
using System.Collections;

public class Begining : MonoBehaviour {
	Animator anim;

	void Awake() {
		GameObject window = GameObject.Find ("Window");
		anim = window.GetComponent<Animator> ();

	}
	public void CloseWindow() {
		anim.SetTrigger("Close");
	}
}
