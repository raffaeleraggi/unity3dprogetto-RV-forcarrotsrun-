using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PCTutorial : MonoBehaviour {

	private CharacterController controller;
  private Vector3 moveVector;


	private float speed = 15.0f;
	private float verticalVelocity = 0.0f;
	private float gravity = 20.0f;


	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController> ();

	}

	// Update is called once per frame
	void Update () {



    moveVector = Vector3.zero;

		if(controller.isGrounded)
		{
			verticalVelocity = -0.5f;
		}else{
			verticalVelocity-= gravity * Time.deltaTime;
		}

		// X - Left and Right
		moveVector.x = Input.GetAxisRaw("Horizontal") * speed;

		if (Input.GetMouseButton(0))
		if(Input.mousePosition.y < Screen.height /2){

		{
			if (Input.mousePosition.x > Screen.width /2)
			  moveVector.x = speed;
				else
				moveVector.x = -speed;
		}
	}


		// Y - Up and Down
		moveVector.y = verticalVelocity;

		if(Input.GetKeyDown("space"))

			controller.transform.Translate(Vector3.up * 2.2f);

      if(controller.isGrounded)
			{
			if (Input.GetMouseButton(0))
			if(Input.mousePosition.y > Screen.height /2){

			{
				if (Input.mousePosition.x < Screen.width /2)
				  controller.transform.Translate(Vector3.up * 2.2f);
					else
					controller.transform.Translate(Vector3.up * 2.2f);
			}
		}
	}


		// Z - Forward and Backward
		moveVector.z = speed;

		controller.Move (moveVector * Time.deltaTime);


    }

		public void BackToMenu()
		{
	     SceneManager.LoadScene("Menu");
		}

		private void OnControllerColliderHit(ControllerColliderHit hit)
		{
			if(hit.gameObject.tag == "End")
           BackToMenu();
					 
			if(hit.gameObject.tag == "ObsTut")
			   SceneManager.LoadScene("Tutorial");
		}


	}
