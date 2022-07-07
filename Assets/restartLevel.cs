using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (Input.GetKey (KeyCode.E)) {

			SceneManager.LoadScene ("mainMap");

		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
