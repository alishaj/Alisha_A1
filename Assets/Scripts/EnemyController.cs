using UnityEngine;
using System.Collections;
//the Source file name : Lab Work
//Author’s name : Alisha Jassal
//Last Modified by : Alisha Jassal
//Date last Modified : October 30, 2016 
//Program description : Enemy Controller to have it reset eveytime it gets destroyed
//Revision History : Everyday?
public class EnemyController : MonoBehaviour {

	[SerializeField]
	private Vector2 speed = Vector2.zero;

	private Transform _transf;
	private Vector2 _currentP;

	//This helps move the direction in positive and negative positions
	private int direction = 1;

	// Use this for initialization
	void Start () {
		_transf = gameObject.GetComponent<Transform>();
		_currentP = _transf.position;
		Reset ();
	}

	// Update is called once per frame
	void FixedUpdate () {
		_currentP = _transf.position;
		Vector2 currSpeed = new Vector2 (speed.x * direction, speed.y);
		_currentP -= currSpeed;
		_transf.position = _currentP;

		if (_currentP.y <= -5.3) {
			Reset ();
		}
	}
	//This will make the enemy appear randomly, 
	//if it gets destroyed it will rest and come from another direction
	public void Reset(){
		direction = -direction;
		_transf.localScale = new Vector2 (direction, 1);
		_currentP = new Vector2 (direction*5f, 5f);
		_transf.position = _currentP;
	}
}
