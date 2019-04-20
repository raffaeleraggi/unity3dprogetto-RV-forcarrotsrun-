using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

	public Text highscoreText;

	public void Start () {
    highscoreText.text = "Highscore : " + ((int)PlayerPrefs.GetFloat("Highscore")).ToString();
  }

	public void ToGame()
	{
		SceneManager.LoadScene("Game");
	}
}
