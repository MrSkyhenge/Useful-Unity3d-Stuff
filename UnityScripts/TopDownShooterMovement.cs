// Very simple script for top-down shooter-type movement. Gameobject will move horizontally and vertically with no
// rotation. This code handles movement only.

using UnityEngine;
using System.Collections;

public class TopDownShooterMovement : MonoBehaviour {

	public float xSpeed = 10f;
	public float zSpeed = 10f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update() {
		float deltaX = Input.GetAxis ("Horizontal") * xSpeed;
		float deltaZ = Input.GetAxis ("Vertical") * zSpeed;

		Vector3 trans = new Vector3(deltaX,0f,deltaZ);
		transform.Translate(trans * Time.deltaTime, Space.World);    
	}
}
