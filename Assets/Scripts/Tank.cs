using UnityEngine;
using System.Collections;
//the Source file name : Lab Work
//Author’s name : Alisha Jassal
//Last Modified by : Alisha Jassal
//Date last Modified : October 30, 2016 
//Program description : Accumulates points when tank hits grenade or decreases if tank hits health
//Revision History : Everyday?
public class Tank {

	private const string key = "HIGH_SCORE";

	private Tank(){
		//get highScore from the PlayerPrefs if it exists
		if (PlayerPrefs.HasKey (key)) {
			_highScore = PlayerPrefs.GetInt (key);
		}

	}

	private static Tank _instance = null;

	public static Tank Instance{

		get{ 
			if (_instance == null) {
				_instance = new Tank ();
			}

			return _instance;
		}
	}

	public HUDController hud = null;
	private int _points = 0;
	public int Points{
		get{ 
			return _points;
		}

		set{ 
			_points = value;
			HighScore = _points;
			hud.UpdatePoints ();
		}
	}

	private int _highScore = 0;

	public int HighScore{
		get{ 
			return _highScore;
		}
		//Only displays highscore if it beats previous highscore
		set{ 
			if (value > _highScore) {
				_highScore = value;
				PlayerPrefs.SetInt (key, _highScore);
			}
		}
	}

	private int _health = 50;
	public int Health{
		get{ 
			return _health;
		}
		//Displays "Game Over" when health hits 0
		set{ 
			_health = value;
			hud.UpdateHealth ();
			if (_health <= 0) {
				hud.GameOver ();
			}
		}
	}

}
