using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tutorial : MonoBehaviour {

	public void ToTutorial()
	{
		 SceneManager.LoadScene("Tutorial");
	}

	public void PageCredits()
	{
		 SceneManager.LoadScene("Credits");
	}

	public void ReturnMenu()
{
	 SceneManager.LoadScene("Menu");
}
}
