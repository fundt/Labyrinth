using UnityEngine;
using System.Collections;

public class loader : MonoBehaviour {
	public GameObject gameManager;

	// Use this for initialization
	void Awake () {
		if (game_manager.instance == null)
			Instantiate (gameManager);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
