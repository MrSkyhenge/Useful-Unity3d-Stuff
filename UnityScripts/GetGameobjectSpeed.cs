// Get the current speed of the gameobject this script is attached to. You can use the vaule of curSpeed to
// to trigger event or actions. Originally posted at Unity Answers.

using UnityEngine;
using System.Collections;
 
public class GetGameobjectSpeed : MonoBehaviour
{
	private Vector3 previousPosition;
	private float curSpeed; //Current speed of gameobject
	
	void Update() {
		Vector3 curMove = transform.position - previousPosition;
		curSpeed = curMove.magnitude / Time.deltaTime;
		previousPosition = transform.position;
	}
}
