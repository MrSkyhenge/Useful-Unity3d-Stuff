//By Cristian Dario Montenegro Bahamon from https://www.youtube.com/watch?v=_cJR6QQ9T94
//Code for handling simple footsteps on a player or other game character...modify to suit your needs. Personally, I've
//used this code with a Unity's Navmesh agent, Mecanim, legacy animation, and other systems with only basic modifications
//needed.


using UnityEngine;
using System.Collections;

public class RandomFootsteps : MonoBehaviour {

	public AudioClip[] footsteps;
	public float nextFoot;

	IEnumerator Start () {
		CharacterController controller = GetComponent<CharacterController> ();

		while (true) {
			if(controller.isGrounded && controller.velocity.magnitude > 0.3F) {
				audio.PlayOneShot(footsteps[Random.Range(0, footsteps.Length)]);
				yield return new WaitForSeconds(nextFoot);
			} else {
				yield return 0;
			}
		}
	}
}
