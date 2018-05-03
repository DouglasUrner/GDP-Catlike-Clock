using System;
using UnityEngine;

public class Clock : MonoBehaviour {
	// Access to clock hands.
	public Transform hourTransform, minuteTransform, secondTransform;

	void Awake() {
		Debug.Log(DateTime.Now);
	}
}
