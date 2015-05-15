using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class game_manager : MonoBehaviour {
	public static game_manager instance = null;

	public float levelStartDelay = 2f;
	private Text scoreText;
	private Text levelText;                                 //Text to display current level number.
	private GameObject levelImage;                          //Image to block out level as levels are being set up, background for levelText.
	private room_manager boardScript;                       //Store a reference to our BoardManager which will set up the level.
	private int level = 1;

	private bool doingSetup;

	// Use this for initialization
	void Awake() {
		boardScript = GetComponent<room_manager>();

		if (instance != null)
			instance = this;
		else if(instance != this)
			Destroy(gameObject);

		DontDestroyOnLoad(gameObject);
		InitGame ();
	}

	private void onLevelWasLoaded(int index){
		level++;
		InitGame ();
	}

	void InitGame (){
		Debug.Log ("InitGame begins");
		doingSetup = true;
		levelImage = GameObject.Find("levelImage");
		
		//Get a reference to our text LevelText's text component by finding it by name and calling GetComponent.
		levelText = GameObject.Find("levelText").GetComponent<Text> ();
		scoreText = GameObject.Find("scoreText").GetComponent<Text>();
		//Set the text of levelText to the string "Day" and append the current level number.
		levelText.text = "Level " + level;
		scoreText.text = "Level " + level;
		
		//Set levelImage to active blocking player's view of the game board during setup.
		levelImage.SetActive(true);	

		Invoke("hide", 1);
		boardScript.BeginSetup ();
		hide ();
		Debug.Log ("finish InitGame");
	}

	void hide(){
		Debug.Log ("should be hiding image");
		//Disable the levelImage gameObject.
		levelImage.SetActive(false);
		
		//Set doingSetup to false allowing player to move again.
		doingSetup = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
