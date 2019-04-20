using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour {
	private CharacterController controller;
	private Vector3 moveVector;
	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController> ();
	}

	// Update is called once per frame
	void Update () {

	}
	public void OnJump(){
		controller.transform.Translate(Vector3.up * 2.2f);
	}
}
