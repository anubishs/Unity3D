using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_Master : MonoBehaviour {

	#region Events
	public delegate void GameManagerEventHandler();
	public event GameManagerEventHandler MenuToggleEvent;
	public event GameManagerEventHandler InventoryUIToogleEvent;
	public event GameManagerEventHandler RestartLevelEvent;
	public event GameManagerEventHandler GoToMenuSceneEvent;
	public event GameManagerEventHandler GameOverEvent;
	#endregion

	#region Variables
	public bool isGameOver;
	public bool isInventoryUIOn;
	public bool isMenuOn;
	#endregion

	public void CallEventMenuToogle()
	{
		if(MenuToggleEvent!= null)
		{
			MenuToggleEvent();
		}
	}

	public void CallEventInventoryUIToogle()
	{
		if (InventoryUIToogleEvent != null)
		{
			InventoryUIToogleEvent();
		}
	}

	public void CallEventRestartLevel()
	{
		if (RestartLevelEvent != null)
		{
			RestartLevelEvent();
		}
	}

	public void CallEventGoToMenuScene()
	{
		if (GoToMenuSceneEvent != null)
		{
			GoToMenuSceneEvent();
		}
	}

	public void CallEventGameOver()
	{
		if (GameOverEvent != null)
		{
			isGameOver = true;
			GameOverEvent();
		}
	}

}
