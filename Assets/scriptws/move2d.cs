using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class move2d : MonoBehaviour {



	// Use this for initialization
	void Start () {

	

		}
	
	// Update is called once per frame
	void Update () {
		Jump ();
	
	}

	void Jump(){
		if (Input.GetMouseButton(0))
		{
			gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, -5.0f), ForceMode2D.Impulse);
		}
	}
}
