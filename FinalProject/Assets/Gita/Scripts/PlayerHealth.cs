using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;
	using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {
    public Slider healthSlider;
    public int healthPoints = 100;                              //starting health points
    public int current;                                         //current amount of health points






    // Use this for initialization
    void Awake() {
        current = healthPoints;

    }



    void OnCollisionEnter(Collision target) {
        if (target.gameObject.tag == "danger_object") {
            Damage(25);

        }
    }

    public void Damage(int amount) {
        current = current - amount;
        healthSlider.value = current;
        if (current <= 0) {
            Death();
        }
    }

    public void Death() {

        transform.position = Vector3.zero;
        current = healthPoints;
        healthSlider.value = current;

    }
}



    