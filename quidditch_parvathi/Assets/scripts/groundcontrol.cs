using UnityEngine;
using System.Collections;

public class groundcontrol : MonoBehaviour {

	float speed = 0.3f;
	
	// Update is called once per frame
	void Update () {
	
		float offset = Time.time * speed;
		GetComponent<Renderer> ().material.mainTextureOffset = new Vector2 (0, -offset);
	}
}