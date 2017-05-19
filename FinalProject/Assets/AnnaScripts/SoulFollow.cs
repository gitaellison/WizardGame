using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulFollow : MonoBehaviour {
	public GameObject player;
	public Vector3 offset;
	public bool work;


	// Use this for initialization
	void Start () {
		work = false;
	}

	// Update is called once per frame
	void LateUpdate () {
		if (work == true) {
			transform.position = player.transform.position + offset;
			transform.forward = player.transform.forward;
		}
	}
	void OnTriggerEnter(Collider other){
		if(other.tag=="Player"){
			player = GameObject.FindWithTag("Player");
			work=true;
		}
	}

}


