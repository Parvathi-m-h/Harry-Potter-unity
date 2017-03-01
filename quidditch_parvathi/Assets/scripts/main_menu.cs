using UnityEngine;
using System.Collections;

public class main_menu : MonoBehaviour {

	// Use this for initialization
	public GUISkin myskin;  //custom GUIskin reference
	public string gameLevel;
	public string optionsLevel;
	public GUIText scoreText;
	public int score;

	private void Start()
	{   
		Time.timeScale=1; //Set the timeScale back to 1 for Restart option to work  
	}
	void Update()
	{
		score =(int)((Time.time) * 100);
		scoreText.text = "score:" + score.ToString ();
	}
	private void OnGUI()
	{
		GUI.skin=myskin;   //use the custom GUISkin
		if (Time.timeScale==0) {
			GUI.Box (new Rect (Screen.width / 4, Screen.height / 4, Screen.width / 2, Screen.height / 2), "MAIN MENU");
		
			if (GUI.Button (new Rect (Screen.width / 4 + 10, Screen.height / 4 + Screen.height / 10 + 10, Screen.width / 2 - 20, Screen.height / 10), "PLAY")) {
				Time.timeScale=1;
				Application.LoadLevel (0);
			}
		
			if (GUI.Button (new Rect (Screen.width / 4 + 10, Screen.height / 4 + 2 * Screen.height / 10 + 10, Screen.width / 2 - 20, Screen.height / 10), "CREDITS")) {
				Application.LoadLevel (optionsLevel);
			}
		
			if (GUI.Button (new Rect (Screen.width / 4 + 10, Screen.height / 4 + 3 * Screen.height / 10 + 10, Screen.width / 2 - 20, Screen.height / 10), "Score:"+ score)) {
				Application.Quit ();
			}
		}
	}
}
