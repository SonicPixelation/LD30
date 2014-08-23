using UnityEngine;
using System.Collections;

public class GUI_Test : MonoBehaviour {

//This is a pure test file of me trying to figure out how GUI's work. I think I got it now, so now I just need to know which GUI's to make, 
	//How you want them set up, and whatever else. Ill see what I can do about finishing all the GUI's, and if you could help figure out the 
	//import of pictures into the UI, as I can't seem to figure it out for some reason. 


	void OnGUI () {

		// This is the background
		GUI.Box (new Rect (Screen.width/2 - 20, 10, 100, 130), "Menu");

		//This is the first button
		if (GUI.Button (new Rect(Screen.width/2 - 10, 40,80,20), "Start Game")) {
		   //replace this text with whatever starts the game
			print ("Game Started!");
		}
		// The four numbers in takes are the starting left most position, starting top most position, total width, and total height, measured in px.
		if (GUI.Button (new Rect (Screen.width/2 - 10,70,80,20), "Options")) {
			//Whatever brings us to options (if we even have options)
			print ("Options Loading");
		}

		if (GUI.Button (new Rect (Screen.width/2 - 10, 100,80,20), "Exit")) {
			//whatever exits the game
			print ("The Game has Died");
		}
	
		//I tried adding a UI element with an image here. I have no idea how to do that the docs made no sense. Ill leave that for you.

		GUI.BeginGroup (new Rect (Screen.width / 2 - 100, Screen.height / 2 - 100, 200, 200));
		//Using Groups, makes the numbers local instead of calculating the entire screen
		//Layouts are kind of weird, been producing some weird results. I'll just stick with fixed for now.

		GUI.Box (new Rect (0, 0, 200, 200), "Auto Menu");
		GUI.Button (new Rect (20, 30, 160, 20), "Group Button" );


		GUI.EndGroup ();
	}



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
