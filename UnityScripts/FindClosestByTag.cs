//Finds the closest object by tag. Code originally posted on Unity Answers

using UnityEngine;
using System.Collections;

public class FindClosestByTag : MonoBehaviour {
    
	GameObject FindClosestTag() {
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("TAG");
        GameObject closest = null;
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;
        foreach (GameObject go in gos) {
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance) {
                closest = go;
                distance = curDistance;
            }
        }
        return closest;
    }
    
	void Update() {
        print(FindClosestTag().name);
    }
}
