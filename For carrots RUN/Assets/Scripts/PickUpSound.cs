using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpSound : MonoBehaviour {

	public AudioClip pickup;

	void OnTriggerEnter(Collider other)  // other is a reference to the other trigger collider we have touched
 {
		 if (other.gameObject.CompareTag ("Player"))
		 {
				 AudioSource.PlayClipAtPoint(pickup, transform.position); 
		 }
 }
}
