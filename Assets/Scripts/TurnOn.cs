using UnityEngine;
using System.Collections;

public class TurnOn : MonoBehaviour {

	private int increment = 0;

	void Start () {
		//Debug.Log("I'm in start.");

	}

	void Update () {

		//Debug.Log("Update:" + increment);

		if (Input.GetKeyDown (KeyCode.Space)) {
			increment++;
		}
	}

	private void Awake () {
		//Debug.Log ("Is Active");
	}

}
