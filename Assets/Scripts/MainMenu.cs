using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class MainMenu : MonoBehaviour
{
	public Animator transition;
	
	public float transitionTime = 1f;
	
	public void Pelaa ()
	{
		StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
	}
	
	public void NoGame ()
	{
		Debug.Log ("THERE IS NOTHING THERE");
		Application.Quit();
	}
	
	IEnumerator LoadLevel(int levelIndex)
	{
		transition.SetTrigger("Trigger");
		
		yield return new WaitForSeconds(transitionTime);
		
		SceneManager.LoadScene(levelIndex);
	}
	
	
}