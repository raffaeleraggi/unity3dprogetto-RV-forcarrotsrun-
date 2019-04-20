using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButton : MonoBehaviour {

	public GameObject pauseButton, pauseMenu;

	public void Start()
	{
		OnUnPause();
	}

  public void OnPause()
	{
		pauseMenu.SetActive(true);
		pauseButton.SetActive(false);
		Time.timeScale = 0;
	}

	public void OnUnPause()
	{
		pauseMenu.SetActive(false);
		pauseButton.SetActive(true);
		Time.timeScale = 1;
	}

}
