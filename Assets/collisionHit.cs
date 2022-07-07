using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collisionHit : MonoBehaviour
{
	public int Score;
	public Texture ScoreText;
	public GameObject pauseMenuUI;
	public int menuOn;
	// Use this for initialization
	void Start()
	{
		Time.timeScale = 0f;
		pauseMenuUI.SetActive(false);


	}



	// Update is called once per frame
	void Update()
	{

		if (menuOn == 1)
		{





			if (Input.GetMouseButton(0))
			{

				SceneManager.LoadScene("mainMap");
			}

		}
	}

	void OnCollisionEnter2D(Collision2D col)
	{

		if (col.gameObject.CompareTag("cannon"))




		{
			Time.timeScale = 0f;
			menuOn = menuOn + 1;
			pauseMenuUI.SetActive(true);

		}


	}

}