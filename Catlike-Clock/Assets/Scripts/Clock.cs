using System;
using UnityEngine;

public class Clock : MonoBehaviour {
	private const float degreesPerHour = 30f;
	private const float degreesPerMinute = 6f;
	private const float degreesPerSecond = 6f;

	public bool continuous = true;

	// Access to clock hands.
	public Transform hourTransform, minuteTransform, secondTransform;

	void Awake() {
		Debug.Log(DateTime.Now);
		hourTransform.localRotation =
			Quaternion.Euler(0f, DateTime.Now.Hour * degreesPerHour, 0f);
		minuteTransform.localRotation =
			Quaternion.Euler(0f, DateTime.Now.Hour * degreesPerMinute, 0f);
		secondTransform.localRotation =
			Quaternion.Euler(0f, DateTime.Now.Hour * degreesPerSecond, 0f);
	}

	void Update() {
		if (continuous) {
			UpdateContinuous();
		} else {
			UpdateDiscrete();
		}
	}

	void UpdateContinuous() {
		TimeSpan time = DateTime.Now.TimeOfDay;

		hourTransform.localRotation =
			Quaternion.Euler(0f, (float) time.TotalHours * degreesPerHour, 0f);
		minuteTransform.localRotation =
			Quaternion.Euler(0f, (float) time.TotalMinutes * degreesPerMinute, 0f);
		secondTransform.localRotation =
			Quaternion.Euler(0f, (float) time.TotalSeconds * degreesPerSecond, 0f);
	}

	void UpdateDiscrete () {
		DateTime time = DateTime.Now;

		hourTransform.localRotation =
			Quaternion.Euler(0f, time.Hour * degreesPerHour, 0f);
		minuteTransform.localRotation =
			Quaternion.Euler(0f, time.Minute * degreesPerMinute, 0f);
		secondTransform.localRotation =
			Quaternion.Euler(0f, time.Second * degreesPerSecond, 0f);
	}
}
