// Conversion of the Click To Move script from the Unity
// Wiki converted to C#

using UnityEngine;
using System.Collections;

public class ClickToMoveC : MonoBehaviour {
 
	public int smooth; // Determines how quickly object moves towards position
	private Vector3 targetPosition;
 
	void  Update (){
		if(Input.GetKeyDown(KeyCode.Mouse0))
		{
			var playerPlane= new Plane(Vector3.up, transform.position);
			var ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			float hitdist= 0.0f;
	 
			if (playerPlane.Raycast (ray, out hitdist)) {
				var targetPoint= ray.GetPoint(hitdist);
				targetPosition = ray.GetPoint(hitdist);
				var targetRotation = Quaternion.LookRotation(targetPoint - transform.position);
				transform.rotation = targetRotation;
			}
		}
	 
		transform.position = Vector3.Lerp (transform.position, targetPosition, Time.deltaTime * smooth);
	}
}