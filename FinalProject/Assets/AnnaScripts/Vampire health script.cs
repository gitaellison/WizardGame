using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vampirehealthscript : MonoBehaviour {


	public int healthPoints=100;								//starting health points
	public int current;			
	public GameObject soul;


	// Use this for initialization
	void Awake () {
		current = healthPoints;

	}


	void OnCollisionEnter (Collision target) {
		if( target.gameObject.tag=="fire"){
			Damage (20);

		}
	}

	public void Damage(int amount){
		current =current-amount;
		if (current<=0){
			Death();
		}
	}

	public void Death(){
		Instantiate (soul, transform.position,transform.rotation);
		Destroy (this);


	}
}
