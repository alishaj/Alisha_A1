using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//the Source file name : Lab Work
//Author’s name : Alisha Jassal
//Last Modified by : Alisha Jassal
//Date last Modified : October 30, 2016 
//Program description : To increase points and decrease health for Game Over
//Revision History : Everyday?
public class HUDController : MonoBehaviour {

	[SerializeField]
	Text pointsLabel = null;
	[SerializeField]
	Text healthLabel = null;

	//new
	[SerializeField]
	Button restartButton = null;
	[SerializeField]
	Text gameOver = null;
	[SerializeField]
	GameObject player = null;
	[SerializeField]
	Text setHighScore = null;
	//Updates Points
	public void UpdatePoints(){

		pointsLabel.text = "Points: " + Tank.Instance.Points;
	
	}
	//Updates Health
	public void UpdateHealth(){
	
		healthLabel.text = "Health: " + Tank.Instance.Health;
	}
		
	// Use this for initialization
	void Start () {
		Tank.Instance.hud = this;
		RestartGame ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public void GameOver(){
	
		//This will hide the health and points label when the game resets at end
		pointsLabel.gameObject.SetActive(false);
		healthLabel.gameObject.SetActive(false);

		//deactives the tank player
		player.SetActive(false);

		//display label of "Game Over" once the player looses all health
		gameOver.gameObject.SetActive(true);
		setHighScore.gameObject.SetActive (true);
		setHighScore.text = "High Score: " + Tank.Instance.HighScore;

		//display "Start" button once game is about to reset 
		restartButton.gameObject.SetActive(true);
	
	}

	public void RestartGame(){

		//During game play this shows the health and points labels
		pointsLabel.gameObject.SetActive(true);
		healthLabel.gameObject.SetActive(true);
		Tank.Instance.Points = 0;
		Tank.Instance.Health = 50;
		setHighScore.gameObject.SetActive (false);

		//This activates the tank once game is in play
		player.SetActive(true);

		//hide "Game Over" label when game is not in play
		gameOver.gameObject.SetActive(false);

		//hide "Restart" button when game is not in play
		restartButton.gameObject.SetActive(false);

	}
}
