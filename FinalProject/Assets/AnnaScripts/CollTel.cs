using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollTel : MonoBehaviour {
    public GameObject Destination;
    
	void OnTriggerStay (Collider other) {
        other.transform.position = Destination.gameObject.transform.position;
	}
	
}
