using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager_GoToMenuScene : MonoBehaviour {

	#region Variables
	private GameManager_Master gameManagerMaster;
	#endregion

	void OnEnable()
	{
		SetInitialReferences();
		gameManagerMaster.GoToMenuSceneEvent += GoToMenuScene;
	}

	void OnDisable()
	{
		gameManagerMaster.GoToMenuSceneEvent -= GoToMenuScene;
	}

	void SetInitialReferences()
	{
		gameManagerMaster = GetComponent<GameManager_Master>();
	}

	void GoToMenuScene()
	{
		SceneManager.LoadScene(0);
	}
}
