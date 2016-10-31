using UnityEngine;
using System.Collections;
//the Source file name : Lab Work
//Author’s name : Alisha Jassal
//Last Modified by : Alisha Jassal
//Date last Modified : October 30, 2016 
//Program description : To have the grenade appear randomly during gameplay
//Revision History : Everyday?
public class GrenadeController : MonoBehaviour {

	[SerializeField]
	private float speed;

	private Transform _transf;
	private Vector2 _currentP;

	private float minx = -3f;
	private float maxx = 3f;

	// Use this for initialization
	void Start () {
		
		_transf = gameObject.GetComponent<Transform>();
		_currentP = _transf.position;
		Reset ();
	}

	// Update is called once per frame
	void FixedUpdate () {
		_currentP = _transf.position;

		_currentP -= new Vector2 (0, speed);
		_transf.position = _currentP;

		if (_currentP.y <= -5.3) {
			Reset ();
		}
			
	}
	//This will generate random placement of the object 
	private void Reset(){
		float xpos = Random.Range (minx, maxx);
		float ypos = Random.Range (5.3f, 20f);
		_currentP = new Vector2 (xpos, ypos);
		_transf.position = _currentP;
	}
}
