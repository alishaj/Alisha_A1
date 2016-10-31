using UnityEngine;
using System.Collections;
//the Source file name : Lab Work
//Author’s name : Alisha Jassal
//Last Modified by : Alisha Jassal
//Date last Modified : October 30, 2016 
//Program description : Audio Sound for when tank hits enemy
//Revision History : Everyday?
public class TankCollider : MonoBehaviour {
	void OnTriggerEnter2D(Collider2D other){
	
		if (other.gameObject.tag == "grenade") {
			//This will show in the console that the tank is colliding with the grenade
			Debug.Log ("Collision with grenade");
			Tank.Instance.Points++;

			//This will show in the console that the tank is colliding with the enemy
		} else if(other.gameObject.tag=="enemy"){
			Debug.Log ("Collision with enemy");

			//When the tank hits the enemy, this will decrease the health by 10
			Tank.Instance.Health = Tank.Instance.Health - 5;

			EnemyController en = 
				other.gameObject.GetComponent<EnemyController> ();

		
			//This plays the blast sound when the tank hits the enemy
			AudioSource asrc = gameObject.GetComponent<AudioSource> ();
			if (asrc != null) {
				asrc.Play ();
		

			}
			//This will help reset the game once health hits 0
			if (en != null) {
				en.Reset ();
			}
				
		}

	}

	void OnCollisionEnter2D(Collision2D other){

		Debug.Log ("Collision");
		if (other.gameObject.tag == "enemy") {
		
			Destroy (other.gameObject);
		}
	
	}
}
