using UnityEngine;
using System.Collections;

public class BackgroundImage : MonoBehaviour {

	GUITexture texture;

	// Use this for initialization
	void Start () {
		texture = GetComponent<GUITexture> ();
	}
	
	// Update is called once per frame
	void Update () {

		Rect pixelInset = texture.pixelInset;

		pixelInset.size = new Vector2(Screen.width, Screen.height);
		pixelInset.position = new Vector2(-(Screen.width / 2.0f), -(Screen.height / 2.0f));

		texture.pixelInset = pixelInset;
	}
}
