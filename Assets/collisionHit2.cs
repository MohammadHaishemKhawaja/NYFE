using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collisionHit2 : MonoBehaviour {
	public GameObject watermelon;
	public int coins; 
	public Text coinText;
	public Transform[] spawnPoints;
	public GameObject[] enemyPrefabs;
	public GameObject watermelonOBJ; 
	public GameObject pauseMenuUI2;
	// Use this for initialization
	void Start () {
		coinText.text = "Coins: " + coins; 
		pauseMenuUI2.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButton (0)) {

			Time.timeScale = 1f;
			pauseMenuUI2.SetActive (false);
		}	
	}


	void OnCollisionEnter2D(Collision2D col) {




		if (col.gameObject.CompareTag ("watermelon"))




		{
			coins = coins + 1;
			print (coins);
			coinText.text = "Coins: " + coins;
			Instantiate (col.gameObject);
			Destroy (col.gameObject);



		}
	}
}