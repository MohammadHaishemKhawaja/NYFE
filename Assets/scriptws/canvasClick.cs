using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class canvasClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (Input.GetMouseButton (0)) {
			print ("ass");
			SceneManager.LoadScene ("mainMap");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
