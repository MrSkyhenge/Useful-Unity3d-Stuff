// Calculates the total distance a game object has travelled. Originally
// posted on Unity Answers

using UnityEngine;
using System.Collections;

public class Distance : MonoBehaviour {

	public float distanceTravelled = 0; // Make private to hide in editor
	Vector3 lastPosition;
	 
	void Start() {
		lastPosition = transform.position;
	}
	 
	void Update() {
		distanceTravelled += Vector3.Distance(transform.position, lastPosition);
		lastPosition = transform.position;
		
		//Example use case
		if (distanceTravelled > 6) {
			// Do something in code here
		}
	}
}
