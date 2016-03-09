// Reference: http://pixelnest.io/tutorials/2d-game-unity/menus/

using UnityEngine;
using System.Collections;

public class start : MonoBehaviour {

	// Use this for initialization
	void OnGUI () {
		const int buttonWidth = 200;
		const int buttonHeight = 30;

		//determine the button's place on screen
		Rect buttonRect = new Rect (
			Screen.width / 2 - (buttonWidth / 2),
			(2 * Screen.height / 3) - (buttonHeight / 2),
			buttonWidth, 
			buttonHeight
		);

		//draw a button to start the game

		if (GUI.Button(buttonRect, "Mano Italiano"))
		{
			Application.LoadLevel("Assignment3");
		}
	}

}