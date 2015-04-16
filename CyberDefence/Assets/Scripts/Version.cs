using UnityEngine;
using System.Collections;

public class Version : MonoBehaviour {

	void OnGUI(){
		// Get label style and center
		var centeredStyle = new GUIStyle(GUI.skin.label);
		centeredStyle.alignment = TextAnchor.MiddleCenter;

		GUI.Label(new Rect(Screen.width/2 - (450 / 2), Screen.height-75, 460, 25), "by Jack Laurel, Gary Sangwell, Chris Ingram, Tom Kellett and Ryan Docherty.", centeredStyle);
		GUI.Label(new Rect(Screen.width/2 - (450 / 2), Screen.height-50, 450, 25), "TDTK Free version 1.0 by K.SongTan", centeredStyle);
	}
}
