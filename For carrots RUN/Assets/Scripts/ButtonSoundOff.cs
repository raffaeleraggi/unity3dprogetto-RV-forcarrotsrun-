using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSoundOff : MonoBehaviour {

	public bool SoundButtonOff;

	 public void Mute()
	 {
		 if(!SoundButtonOff){
			 SoundButtonOff = true;
			 AudioListener.pause = true;
		 }
		 else{
			 SoundButtonOff = false;
			 AudioListener.pause = false;
		 }
	 }



}
