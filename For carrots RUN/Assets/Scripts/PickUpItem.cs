using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PickUpItem : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		
         Destroy(other.gameObject);


}
}
