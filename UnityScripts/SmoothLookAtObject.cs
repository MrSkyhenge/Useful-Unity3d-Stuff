// Rotates an object to smoothly rotate and look at another object
// From Unity Forums as http://forum.unity3d.com/threads/smooth-look-at-on-y-axis-only.87141/ and converted to C#

using UnityEngine;
using System.Collections;

public class SmoothLookAtObject : MonoBehaviour {

	public Transform target; //Transform to look at
	public float rotSpeed; //Rotation speed
	
	void Update () {
		var targetPos = target.position;
		targetPos.y = transform.position.y; //set targetPos y equal to mine, so I only look at my own plane
		var targetDir = Quaternion.LookRotation(targetPos - transform.position);
		transform.rotation = Quaternion.Slerp(transform.rotation, targetDir, rotSpeed*Time.deltaTime);
	}
}
