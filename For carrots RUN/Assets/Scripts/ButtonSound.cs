using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSound : MonoBehaviour {

	public bool SoundButtonOn;

	 public void UnMute()
	 {
		 if(!SoundButtonOn){
			 SoundButtonOn = false;
			 AudioListener.pause = false;
		 }
		 else{
			 SoundButtonOn = true;
			 AudioListener.pause = true;
		 }
	 }



}
