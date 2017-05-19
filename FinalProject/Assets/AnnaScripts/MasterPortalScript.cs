using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterPortalScript : MonoBehaviour {
	public bool ready=false;
	public GameObject st1;
	public GameObject st2;
	public GameObject st3;
	public GameObject st4;
	Point p1;
	Point p2;
	Point p3;
	Point p4;

	void Start () {
		ready = false;
	}
	// Update is called once per frame
	void Update () {
		p1= st1.GetComponent<Point>();
		p2= st2.GetComponent<Point>();
		p3= st3.GetComponent<Point>();
		p4= st4.GetComponent<Point>();
		if(p1.souln==5 && p2.souln==5 && p3.souln==5 && p4.souln==5){
			ready=true;
		}

	}
	
	void OnTriggerEnter(Collider other){

		if(other.tag=="Player" && ready==true){
			Application.LoadLevel ("Scene2-Gita");
		}



	}
}
