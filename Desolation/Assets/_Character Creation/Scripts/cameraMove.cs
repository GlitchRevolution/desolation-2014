using UnityEngine;
using System.Collections;

public class cameraMove : MonoBehaviour {

	private bool cameraMovement = false;
	private bool GUIon = true;
	private bool sceneEnd = false;
	public Texture2D logo;
	public AudioClip introSound;

	void Update() {
		if (cameraMovement == true) {
			transform.Translate(Vector3.up * Time.deltaTime);
			if (transform.position.y >= 26.78f)
			{
				cameraMovement = false;
				if (sceneEnd == false) {
				EndScene ();
				}
			}
				}
	}

	void OnGUI() {
		if (GUIon == true) {
						if (GUI.Button (new Rect (10, 70, 50, 30), "Start")){
				cameraMovement = true;
				GUIon = false;
			}
		}
		if (GUIon == false) {
			if (GUI.Button (new Rect (10, 70, 50, 30), "Reload")){
				Application.LoadLevel(0);
			}
		}
		if (sceneEnd == true) {
						GUI.DrawTexture (new Rect (Screen.width / 2 - 250, Screen.height / 2 - 100, 500, 200), logo, ScaleMode.ScaleToFit, true, 10.0F);
				}
	}

	void EndScene() {
		sceneEnd = true;
		AudioSource.PlayClipAtPoint(introSound, transform.position);
		Invoke ("LoadLevel", 3);
	}

	void LoadLevel() {
		Application.LoadLevel (0);
	}

}
