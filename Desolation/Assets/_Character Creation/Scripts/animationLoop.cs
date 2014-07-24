using UnityEngine;
using System.Collections;

public class animationLoop : MonoBehaviour {
	public AnimationClip fidget;

 void Awake() { 
		FigetAnimation ();
	}

	void FigetAnimation() {
		animation.CrossFade(fidget.name);
		Invoke ("FigetAnimation", 4);
	}
}
