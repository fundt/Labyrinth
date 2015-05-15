using UnityEngine;
using System;
using System.Collections.Generic;
using Random = UnityEngine.Random;

public class room_manager : MonoBehaviour {
	public int good_door;
	public GameObject doorL;
	public GameObject doorR;

	// Use this for initialization
	void BoardSetup(){
		int good_door = Random.Range (0, 1);
	}

	public void BeginSetup() {
		Debug.Log ("Beginning Setup");
		BoardSetup ();
		GameObject left = Instantiate (doorL, new Vector3 (-2.5f, 2.64f, 0f), Quaternion.identity) as GameObject;
		GameObject right = Instantiate (doorR, new Vector3 (2.5f, 2.64f, 0f), Quaternion.identity) as GameObject;
		if (good_door == 0) {
			left.transform.tag = "good";
			right.transform.tag = "bad";
		} else {
			left.transform.tag = "bad";
			right.transform.tag = "good";
		}
		Debug.Log ("finish setting the board");
	}
}
