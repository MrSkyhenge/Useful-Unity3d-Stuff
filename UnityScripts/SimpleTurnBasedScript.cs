// This is a very, very simple example of ho to switch turns between a player and enemy.
// Attack this script to a game object in your scene and run
// Originally posted somewhere on Unity Answers and has been slightly modified

using UnityEngine;
using System.Collections;

public class SimpleTurnBasedScript : MonoBehaviour{
	bool displayGui = false;
	
	void Awake () {

	}

	void Start () {
		Invoke("PlayerTurn", 1f); //Immediately start our loop
	}

	void Update () {
		
	}
	
	void PlayerTurn(){
		Debug.Log ("Player Turn"); //Logs the player's turn to the console
		displayGui = true;
		//Insert your player-specific code here
	}
	
	void EnemyTurn(){
		Debug.Log ("Enemy Turn"); //Logs the enemy's turn to the console
		displayGui = false;
		// Enemy turn waits five seconds in this example. Change to enemy-specific code here
		Invoke("PlayerTurn", 5f);  
	}
	
	void OnGUI() {
        if (!displayGui) return;
		if (GUI.Button(new Rect(10, 10, 70, 50), "End Turn"))
			Invoke("EnemyTurn", 0.1f);
	}
}



