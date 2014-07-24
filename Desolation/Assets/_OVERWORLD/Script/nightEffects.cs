using UnityEngine;
using System.Collections;

public class nightEffects : MonoBehaviour {
	public GameObject childLight;
	public float thisHour;

	void Update() {
		thisHour = GetComponent<Tod_C> ().Hour;
		if (thisHour > 19 || thisHour < 6) {
			childLight.active = true;
		} 
		if (thisHour <= 19 && thisHour >= 6) {
			childLight.active = false;
		}
	}
}
