using UnityEngine;
using System.Collections;

public class objectcontrol : MonoBehaviour {

	float speed=20f;
	float t;


		// ...
		//transform.position -= Vector3.forward * ((Time.deltaTime)*speed); // or transform.position, both would work

		void Update () {
		t = Time.time;
		if (t <= 3)
			speed = 5f;
		else if (t <= 6)
			speed = 10f;
		else 
			speed = 15f;

		transform.position -= Vector3.forward * ((Time.deltaTime)*speed); // or transform.position, both would work

		}


}


