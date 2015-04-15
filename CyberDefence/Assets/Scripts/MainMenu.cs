using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
	void OnGUI(){

		// Get button style and center
		var centeredStyle = new GUIStyle(GUI.skin.button);
		centeredStyle.alignment = TextAnchor.MiddleCenter;

		if(GUI.Button(new Rect(Screen.width/2 - (100 / 2), Screen.height / 2 - 70, 100, 40), "Start", centeredStyle)){
			Application.LoadLevel("Level1");
		}

		if(GUI.Button(new Rect(Screen.width/2 - (100 / 2), Screen.height / 2 - 15, 100, 40), "Help", centeredStyle)){
			Application.LoadLevel("Help");
		}

		if(GUI.Button(new Rect(Screen.width/2  - (100 / 2), Screen.height / 2 + 40, 100, 40), "Exit", centeredStyle)){
			Application.Quit();
		}
	}
}
