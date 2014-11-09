// Adapted from various iTween resources and examples. Moves player or other game game object on grid along X axis then Z axis.
// This simply moves a game object around a grid of tiles or nodes and IS NOT pathfinding...there is no avoidance.
// For more information and documentation for iTween please visit http://itween.pixelplacement.com/index.php
// 
// VERY basic instructions:
// 1) Grid a grid of tiles using whatever method you like. You can simply make flat cubes and arrange them in editor.
// 2) Create a new tag to be used to make sure the mouse click is hitting a grid tile. I used NODE in this script.
// 3) Assign the tag you created in step #2 to all of your grid tiles/nodes.
// 4) Attach this script to the player game object.

using UnityEngine;
using System.Collections;

public class ItweenMouseGridMovement : MonoBehaviour {

	public GameObject player; //Player game object 
	public int rate = 10; //Movement rate
	public Transform target; //Grid node target
	
	void Update () {
		if (Input.GetMouseButtonDown(0)){
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray, out hit) && hit.transform.CompareTag("Node")){
				target = hit.transform;
				float travelTime = Vector3.Distance(player.transform.position, target.transform.position)/rate;
				iTween.MoveBy(player,iTween.Hash("x",target.transform.position.x-player.transform.position.x,"easetype","easeinoutsine","time",travelTime));
				iTween.MoveBy(player,iTween.Hash("z",target.transform.position.z-player.transform.position.z,"time",travelTime,"delay",travelTime,"easetype","easeinoutsine"));
			}
		}
	}
}
