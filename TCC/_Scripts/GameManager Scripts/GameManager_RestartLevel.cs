using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager_RestartLevel : MonoBehaviour {

	#region Variables
	private GameManager_Master gameManagerMaster;
	#endregion

	void OnEnable()
	{
		SetInitialReferences();
		gameManagerMaster.RestartLevelEvent += RestartLevel;
	}

	void OnDisable()
	{
		gameManagerMaster.RestartLevelEvent -= RestartLevel;
	}

	void SetInitialReferences()
	{
		gameManagerMaster = GetComponent<GameManager_Master>();
	}

	void RestartLevel()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}
