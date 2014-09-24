// Script to click to select and de-select gameobjects by tag. Originally posted on Unity Answers

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ClickToSelectObject : MonoBehaviour {

  public Transform selectedTarget;

  void Update(){
    if (Input.GetMouseButtonDown(0)){ // when button clicked
      RaycastHit hit; // cast a ray from mouse pointer
      Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
      // if enemy hit...
      if (Physics.Raycast(ray, out hit) && hit.transform.CompareTag("Player")){
        DeselectTarget(); // deselect previous target (if any)...
        selectedTarget = hit.transform; // set the new one...
        SelectTarget(); // and select it
      }
    }
  }

  private void SelectTarget(){
    selectedTarget.renderer.material.color = Color.red;
    // Do something in code here
  }

  private void DeselectTarget(){
    if (selectedTarget){ // if any guy selected, deselect it
      selectedTarget.renderer.material.color = Color.blue;
      selectedTarget = null;
    }
  }
}
