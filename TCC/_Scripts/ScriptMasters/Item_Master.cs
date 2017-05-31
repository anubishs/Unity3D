using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Master : MonoBehaviour {

	#region Variables
	private Player_Master playerMaster;
	#endregion

	#region Events
	public delegate void GeneralEventHandler();
	public event GeneralEventHandler EventObjectPickUp;

	public delegate void PickupActionEventHandler(Transform item);
	public event PickupActionEventHandler EventPickupAction;
	#endregion

	void OnEnable()
	{
		
	}

	void Start()
	{
		SetInitialReferences();
	}

	public void CallEventObjectPickup()
	{
		if(EventObjectPickUp != null)
		{
			EventObjectPickUp();
		}
	}

	public void CallEventPickupAction(Transform item)
	{
		if (EventPickupAction != null)
		{
			EventPickupAction(item);
		}
	}

	void SetInitialReferences()
	{
		if(GameManager_References._player != null)
		{
			playerMaster = GameManager_References._player.GetComponent<Player_Master>();
		}
	}
}
