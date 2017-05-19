using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour {
	public Slider healthSlider;     
	public int healthPoints=100;								//starting health points
	public int current;											//current amount of health points
	public GameObject spawner;





	// Use this for initialization
	void Awake () {
		current = healthPoints;

	}
	


	void OnCollisionEnter (Collision target) {
		if( target.gameObject.tag=="enemy"){
			Damage (20);
		
		}

	}


	void OnTriggerEnter (Collider target) {
		if( target.gameObject.tag=="LifeBall"){
			if (current < healthPoints) {
				int delta = healthPoints - current;
				if (delta >= 20) {
					current = current + 20;
				} else {
					current = healthPoints;
				}

				healthSlider.value = current;
			}
		}
	}


	public void Damage(int amount){
		current =current-amount;
		healthSlider.value = current;
		if (current<=0){
			Death();
		}
}

	public void Death(){
		
		this.transform.position = spawner.transform.position;
		current = healthPoints;
		healthSlider.value = current;

}
}
