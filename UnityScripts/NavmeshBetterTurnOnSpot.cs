// Modification of Unity's standard Navmesh SetDestination from the scripting API with the addition of a
// speed multiplier from http://forum.unity3d.com/threads/navmeshagent-questions.144540/ to increase rotation speed
// responsiveness. This is a simple example and could definitely be optimized further.


using UnityEngine;
using System.Collections;

public class NavmeshBetterTurnOnSpot : MonoBehaviour {
    
	private NavMeshAgent agent;
	public float moveSpeed; //Overides Navmesh Agent SPEED paramter
	public float rotationSpeed = 500; //Updates Navmesh Agent angular speed - set higher to rotate faster
	   
	void Start() {
        agent = GetComponent<NavMeshAgent>();
    }
    
	void Update() {
        agent.angularSpeed = rotationSpeed;
		float speedMultiplyer = 1.0f - 0.9f*Vector3.Angle(transform.forward, agent.steeringTarget-transform.position)/180.0f;
		agent.speed = moveSpeed*speedMultiplyer;
		RaycastHit hit;
        if (Input.GetMouseButtonDown(0)) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
				agent.SetDestination(hit.point);
        }
    }
}
