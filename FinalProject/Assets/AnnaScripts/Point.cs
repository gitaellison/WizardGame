using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour {
	public GameObject goal;
	public GameObject magiwork;
	public bool workin;
	public int souln;
	public int soulall=5;

	// Use this for initialization
	void Start () {
		souln = 0;
		workin = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (souln == soulall) {
			Vector3 loc = new Vector3(transform.position.x,2,transform.position.z);
			Instantiate (magiwork, loc , transform.rotation);
		}
	}


	void OnTriggerEnter(Collider other){
		Debug.Log("ip");
		Debug.Log(other.tag);
		if(other.tag=="soul" && souln<soulall){
			souln++;
			Destroy (other.gameObject);
		}
	}
}
