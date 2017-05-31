using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	#region Variables
	#endregion

	public void PlayGame()
	{
		SceneManager.LoadScene(1);
	}

	public void Exit()
	{
		Application.Quit();
	}

	public void TestZone()
	{
		SceneManager.LoadScene(2);
	}
}
