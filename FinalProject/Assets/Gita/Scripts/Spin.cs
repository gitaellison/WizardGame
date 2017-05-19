using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour {

    public float speed;
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.left, speed * Time.deltaTime);
	}
}
