// Modified version from Unity Answers at http://answers.unity3d.com/questions/181594/how-to-get-mouse-cursor-position-on-plane-and-set.html
// Converted to C# with additional code to calculate and display distance in world space

using UnityEngine;
using System.Collections;

public class DistanceToMouse : MonoBehaviour {

	public float mouseDistance; //Displays distance to mouse cursor in the inspector

	void Update () {
		var playerPlane = new Plane(Vector3.forward, transform.position); //Creates a plane centered on the game object
		var playerRay = Camera.main.ScreenPointToRay (Input.mousePosition); //Creates a ray from the main camera to the mouse cursor
		float mouseHitDist = 0.0f;
		if (playerPlane.Raycast (playerRay, out mouseHitDist)) {
			var hitPoint = playerRay.GetPoint(mouseHitDist);
			mouseDistance = Vector3.Distance(transform.position,hitPoint); // Determines distance between the object and hit point
		}
	}
}
