using UnityEngine;
using System.Collections;

public class textBillboard : MonoBehaviour {
	public Camera m_Camera;
	public Color ownerColor;

	void Awake() {
		m_Camera = GameObject.FindWithTag ("MainCamera").camera;
	}

	void UpdateOwner() {
		GetComponent<tk2dTextMesh> ().color = ownerColor;
	}
	void Update()
	{
		transform.LookAt(transform.position + m_Camera.transform.rotation * Vector3.forward,
		                 m_Camera.transform.rotation * Vector3.up);
	}
}
