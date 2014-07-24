using UnityEngine;
using System.Collections;

public class textName : MonoBehaviour {
	public int textSize;
	public Color ownerColor;
	void Awake() {
		GetComponent<TextMesh>().text = transform.parent.name;
	}
	void Update() {
		GetComponent<TextMesh>().fontSize = textSize;
		}
	void Conquer() {
		GetComponent<TextMesh>().color = ownerColor;
		}
}
