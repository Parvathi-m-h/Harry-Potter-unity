using UnityEngine;
using System.Collections;

public class newscript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	//void Update () {
	 //this.transform.Translate(Input.GetAxis("Horizontal"),0,0);
	public float speed = 5f;
	public float momentum = 0;
	public float damping = 5;         

	void Update()
	{
		float momentumSpeed = 50f;            // initial speed that is added to the character               
		float damping = 5;                   // increase this value to stop quickly
		bool arrowKeysUp = true;             // boolean flag to indicate that the arrow keys arn't pressed
		float momentum = 0;

		
		// if user press any arrow key and you wern't press the any arrow key the last frame
		if (Input.GetAxis("Horizontal") != 0f || Input.GetAxis("Vertical") != 0f && arrowKeysUp == true)
		{
			momentum = momentumSpeed;
			
			arrowKeysUp = false;
		}
		else
			arrowKeysUp = true;
		
		transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * momentum * Time.deltaTime);
		
		transform.Translate(Vector3.up * Input.GetAxis("Vertical") * momentum * Time.deltaTime);
		
		if (momentum > 0f)
			// decrease the momentum each frame
			momentum -= (damping * Time.deltaTime);
	}
	
}

