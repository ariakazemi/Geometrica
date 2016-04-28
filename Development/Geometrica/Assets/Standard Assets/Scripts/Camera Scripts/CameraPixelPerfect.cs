using UnityEngine;
using System.Collections;

public class CameraPixelPerfect : MonoBehaviour {

	public static float pixelRatio = 1.0f;
	public static float scale = 1.0f;

	public Vector2 RES = new Vector2(700	, 300);

	void Awake () {
		var camera = GetComponent<Camera> ();

		if (camera.orthographic) {
			Debug.Log(Screen.height);
			Debug.Log(RES.y);
			scale = Screen.height / RES.y;
			Debug.Log(scale);
			pixelRatio *= scale;
			Debug.Log(pixelRatio);

			camera.orthographicSize = (Screen.height / 2.0f) / pixelRatio;
			Debug.Log(Screen.height / 2.0f);
		}
	}

}
