using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {
	public GameObject player;
	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
	//	transform.position = player.transform.position + player.transform.forward * 2;
	//	transform.Translate(Vector3.up * 1, Space.World); 

		transform.position = player.transform.position + player.transform.forward * 2;
		Vector3 position = transform.position;
		position.y += 1;
		transform.position = position;
		transform.forward = player.transform.forward*2;
	}
}
