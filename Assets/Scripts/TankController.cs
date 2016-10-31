using UnityEngine;
using System.Collections;
//the Source file name : Lab Work
//Author’s name : Alisha Jassal
//Last Modified by : Alisha Jassal
//Date last Modified : October 30, 2016 
//Program description : Controls movement of tank
//Revision History : Everyday?
public class TankController : MonoBehaviour {

	[SerializeField]
	private float speed;

	private Transform _transform;
	private Vector2 _currentPosition;
	private float _TankInput;

	// Use this for initialization
	void Start () {
	
		_transform = gameObject.GetComponent<Transform>();
		_currentPosition = _transform.position;
	}
	
	// Update is called once per tick
	void FixedUpdate () {
	//This controls the tank to move left to right or with WASD keys
		_TankInput = Input.GetAxis ("Horizontal");
		_currentPosition = _transform.position;
		//move tanks right
		if (_TankInput > 0) {
			_currentPosition += new Vector2 (speed, 0);
		}
		//move tank left
		if (_TankInput < 0) {
			_currentPosition -= new Vector2 (speed, 0);
		}
		//fix bounds of tank
		checkingBounds ();
		_transform.position = _currentPosition;
	}


	private void checkingBounds(){
	
		if (_currentPosition.x < -2.9f) {
			_currentPosition.x = -2.9f;
		}
		if (_currentPosition.x > 2.9f) {
			_currentPosition.x = 2.9f;
		}
	}

}
