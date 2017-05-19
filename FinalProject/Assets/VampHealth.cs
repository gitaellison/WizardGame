using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VampHealth : MonoBehaviour {


	public int healthPoints=100;								//starting health points
	public int current;			
	public GameObject soul;
	public GameObject myself;

	// Use this for initialization
	void Awake () {
		current = healthPoints;

	}


	void OnTriggerEnter (Collider target) {
		Debug.Log (target.gameObject.tag);
		if( target.gameObject.tag=="Fire"){
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
		Vector3 loc = new Vector3(transform.position.x,1,transform.position.z);
		Instantiate (soul, loc,transform.rotation);
		Destroy (myself);


	}
}
