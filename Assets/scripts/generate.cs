using UnityEngine;
using System.Collections;

public class generate : MonoBehaviour {
	public GameObject rocks;
	int score = 0;
	GUIStyle smallFont;
	GUIStyle largeFont;



	// Use this for initialization
	void Start () {
		smallFont = new GUIStyle();
		largeFont = new GUIStyle();

		smallFont.fontSize = 10;
		largeFont.fontSize = 32;
		
		InvokeRepeating ("CreateObstacle", 1f, 1.5f);
	}

	void OnGUI ()
	{
		GUI.color = Color.black;
		GUILayout.Label (" Score:" + score.ToString (),largeFont);
	}
	void CreateObstacle()
	{
		Instantiate (rocks);
		score++;
	}
	
	// Update is called once per frame
}
