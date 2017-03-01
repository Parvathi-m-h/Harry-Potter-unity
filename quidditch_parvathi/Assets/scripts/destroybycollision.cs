using UnityEngine;
using System.Collections;

public class destroybycollision : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{
		Destroy(other.gameObject);
		Time.timeScale = 0;
	}
}
