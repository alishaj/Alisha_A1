using UnityEngine;
using System.Collections;
//the Source file name : Lab Work
//Author’s name : Alisha Jassal
//Last Modified by : Alisha Jassal
//Date last Modified : October 30, 2016 
//Program description : Continuous loop of sand
//Revision History : Everyday?
public class SandController : MonoBehaviour {
	[SerializeField]
	private float speed;

	private Transform _transf;
	private Vector2 _currentP;

	// Use this for initialization
	void Start () {
		_transf = gameObject.GetComponent<Transform>();
		_currentP = _transf.position;
		Reset ();
	}
	
	// Update is called once per frame
	void Update () {
		_currentP = _transf.position;

		//This function will keep the loop of the sand image to continuously reset 
		//This will ensure the game looks as if its never ending 
		_currentP -= new Vector2 (0, speed);
		_transf.position = _currentP;

		if (_currentP.y <= -5.3) {
			Reset ();
		}
	}

	private void Reset(){
	
		_currentP = new Vector2 (0, 4.3f);
		_transf.position = _currentP;
	}
}
