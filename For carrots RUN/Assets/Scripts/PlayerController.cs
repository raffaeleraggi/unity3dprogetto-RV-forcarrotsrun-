using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {



	private CharacterController controller;
  private Vector3 moveVector;

	private float speed = 45.0f;
	private float verticalVelocity = 0.0f;
	private float gravity = 20.0f;
	private float speedChangeTime=5f;
	private float defaultSpeed;

	private bool isDead = false;

	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController> ();

	}



	// Update is called once per frame
	void Update () {


    if(isDead)
		return;

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




  /*    if(controller.isGrounded)
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
	}*/


		// Z - Forward and Backward
		moveVector.z = speed;

		controller.Move (moveVector * Time.deltaTime);


    }

		public void OnJump(){
			controller.transform.Translate(Vector3.up * 2.2f);
		}


		public void SetSpeed (float modifier)
		{
			speed = 45.0f + modifier * 3;
			defaultSpeed= speed;
		}


		void OnTriggerEnter(Collider other) {
			 if(other.gameObject.CompareTag("speedup")) {
					StartCoroutine(TempSpeedChange(30.0f));
			 }
		}

		IEnumerator TempSpeedChange(float speedValue) {
			 speed += speedValue;
			 yield return new WaitForSeconds(speedChangeTime);
			 speed = defaultSpeed;
		}

private void OnControllerColliderHit(ControllerColliderHit hit)
{
	if(hit.point.z > transform.position.z + 0.1f && hit.gameObject.tag == "Enemy")
		 Death();
}
private void Death()
{
	isDead = true;
  GetComponent<Score>().OnDeath();
}


}
