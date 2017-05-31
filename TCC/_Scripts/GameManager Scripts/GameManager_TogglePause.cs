using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_TogglePause : MonoBehaviour {

	#region Variables
	private GameManager_Master gameManagerMaster;
	public bool isPaused;
	#endregion
	
	void OnEnable()
	{
		SetInitialReferences();
		gameManagerMaster.MenuToggleEvent += TogglePause;
		gameManagerMaster.InventoryUIToogleEvent += TogglePause;
	}

	void OnDisable()
	{
		gameManagerMaster.MenuToggleEvent -= TogglePause;
		gameManagerMaster.InventoryUIToogleEvent -= TogglePause;
	}

	void SetInitialReferences()
	{
		gameManagerMaster = GetComponent<GameManager_Master>();
	}

	void TogglePause()
	{
		if (isPaused)
		{
			Time.timeScale = 1;
			isPaused = false;
		}
		else
		{
			Time.timeScale = 0;
			isPaused = true;
		}
	}
}
