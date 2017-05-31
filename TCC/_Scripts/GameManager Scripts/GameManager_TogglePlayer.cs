using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_TogglePlayer : MonoBehaviour {

	#region Variables
	public WowCamera orbit;
	//public Raycast3 ray;
	//public Lookatcamera look;
	private GameManager_Master gameManagerMaster;
	#endregion

	void Start()
	{
		orbit = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<WowCamera>();
		//ray = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Raycast3>();
		//look = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Lookatcamera>();
	}

	void OnEnable()
	{
		SetInitialReferences();
		gameManagerMaster.MenuToggleEvent += TogglePlayerController;
		gameManagerMaster.InventoryUIToogleEvent += TogglePlayerController;
	}

	void OnDisable()
	{
		gameManagerMaster.MenuToggleEvent -= TogglePlayerController;
		gameManagerMaster.InventoryUIToogleEvent -= TogglePlayerController;
	}

	void SetInitialReferences()
	{
		gameManagerMaster = GetComponent<GameManager_Master>();
	}

	void TogglePlayerController()
	{
		if(orbit != null)
		{
			orbit.enabled = !orbit.enabled;
			//ray.enabled = !ray.enabled;
			//look.enabled = !look.enabled;
		}
	}
}
