using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_ToggleMenu : MonoBehaviour {

	#region Variables
	private GameManager_Master gameManagerMaster;
	public GameObject menu;
	public GameObject objs;
	#endregion

	void Start()
	{
		ToggleMenu();
	}

	void Update()
	{
		CheckForMenuToggleRequest();
	}

	void OnEnable()
	{
		SetInitialReferences();
		gameManagerMaster.GameOverEvent += ToggleMenu;
	}

	void OnDisable()
	{
		gameManagerMaster.GameOverEvent -= ToggleMenu;
	}

	void SetInitialReferences()
	{
		gameManagerMaster = GetComponent<GameManager_Master>();
	}

	void CheckForMenuToggleRequest()
	{
		if(Input.GetKeyUp(KeyCode.Escape) && !gameManagerMaster.isGameOver && !gameManagerMaster.isInventoryUIOn)
		{
			ToggleMenu();
		}
	}

	void ToggleMenu()
	{
		if(menu != null)
		{
			menu.SetActive(!menu.activeSelf);
			objs.SetActive(!objs.activeSelf);
			gameManagerMaster.isMenuOn = !gameManagerMaster.isMenuOn;
			gameManagerMaster.CallEventMenuToogle();
		}
		else
		{
			Debug.LogWarning("You need to assign a UI in inspector");
		}
	}
}
