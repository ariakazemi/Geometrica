using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour {
	public void ChangeSceneTo (int SceneIndex) {
		Application.LoadLevel (SceneIndex);
	}

}
