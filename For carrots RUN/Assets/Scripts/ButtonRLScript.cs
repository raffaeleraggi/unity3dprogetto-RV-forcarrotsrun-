using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonRLScript : MonoBehaviour {
	private CharacterController controller;
	private Vector3 moveVector;

	private float speed = 50.0f;

	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController> ();
	}

public void Right(){
   //controller.transform.Translate(Vector3.right * 2);
   moveVector.x = speed;
}

public void Left(){
  	//controller.transform.Translate(Vector3.left * 2);
    moveVector.x = -speed;
}

}
