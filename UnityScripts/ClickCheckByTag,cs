// Example script showing how to use raycast to click on an object and do something based on the object's tag.
// Modified from an example posted on Unity Answers with code comments added by me

using UnityEngine;
using System.Collections;

public class ClickCheckByTag : MonoBehaviour {
	
	// Update is called once per frame
	void Update(){
		if (Input.GetMouseButtonDown(0)) {
			RaycastHit hitInfo = new RaycastHit();
			bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
			if (hit) {
				Debug.Log("Hit " + hitInfo.transform.gameObject.name);	// Displays the name of the gameobject
				if (hitInfo.transform.gameObject.tag == "TAG")	{	// Specify tag
					Debug.Log ("It's working!");	// Clicked on a gameobject with the right tag 
					// Do some stuff in code here
				} else {
					Debug.Log ("Nope!");	// Clicked on a gameobject with the wrong tag or no tag at all
					// Do some stuff in code here
				}
			} else {
				Debug.Log("Hit nothing!");	// Clicked on empty space
				// Do some stuff in code here
			}
		} 
	}
}
