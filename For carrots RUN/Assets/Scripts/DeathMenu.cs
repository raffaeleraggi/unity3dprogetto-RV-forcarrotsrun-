using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour {

  public Text highscoreText;
	public Text scoreText;
	public Image backgroundImg;


	private bool isShowned = false;

	private float transition = 0.0f;

	// Use this for initialization
	void Start () {
		gameObject.SetActive (false);
		//highscoreText.text = "Highscore : " + ((int)PlayerPrefs.GetFloat("Highscore")).ToString();



	}

	// Update is called once per frame
	void Update () {
		if(!isShowned)
		   return;

		transition += Time.deltaTime;
		backgroundImg.color = Color.Lerp(new Color(0,0,0,0),Color.black, transition);

	}

	public void ToggleEndMenu(float score)
	{
		gameObject.SetActive(true);
		scoreText.text = ((int)score).ToString ();
		isShowned = true;
	}

	public void Restart()
	{
		//SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    SceneManager.LoadScene("Game"); //più pratico
	}

	public void BackToMenu()
	{
     SceneManager.LoadScene("Menu");
	}

}
