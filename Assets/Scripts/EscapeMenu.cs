using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class EscapeMenu : MonoBehaviour
{
	public static bool GameIsPaused = false;
	
	public GameObject pauseMenuUI;
	
	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			if (GameIsPaused)
			{
				Resume();
			}
			else
			{
				Pause();
			}
		}
	}
	
	void Resume ()
	{
		pauseMenuUI.SetActive(false);
		Time.timeScale = 1f;
		GameIsPaused = false;		
	}
	
	void Pause ()
	{
		pauseMenuUI.SetActive(true);
		Time.timeScale = 0f;
		GameIsPaused = true;
	}
	
	public void LoadMenu()
	{
		Time.timeScale = 1f;
		GameIsPaused = false;		
		SceneManager.LoadScene("MainMenu");
	}
	
	public void InvokeTheEnd()
	{
		Resume();
	}
	
}