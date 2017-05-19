using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompassScript : MonoBehaviour {
	public Transform player;
	public Texture compass;
	public Texture pointer;

	void OnGUI(){
		GUI.DrawTexture (new Rect(0,0,120,120), compass);
		GUI.DrawTexture (CreateIt (), pointer);
	}
	Rect CreateIt(){
		float ang = player.eulerAngles.y - 90;
		float angd = ang * Mathf.Deg2Rad;
		float poX = 23 * Mathf.Cos (angd);
		float poY = 23 * Mathf.Sin (angd);

		poX += 55;
		poY += 55;
		return new Rect (poX,poY,10,10);

	}
}
