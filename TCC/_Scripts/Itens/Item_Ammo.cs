using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Ammo : MonoBehaviour {

	#region Variables
	private Item_Master itemMaster;
	private GameObject playerGo;
	public string ammoName;
	public int quantity;
	public bool isTriggerPickup;
	#endregion

	void OnEnable()
	{
		SetInitialReferences();
		itemMaster.EventObjectPickUp += TakeAmmo;
	}

	void OnDisable()
	{
		itemMaster.EventObjectPickUp -= TakeAmmo;
	}

	void Start () 
	{
		SetInitialReferences();
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag(GameManager_References._playerTag) && isTriggerPickup)
		{
			TakeAmmo();
		}
	}
	

	void SetInitialReferences()
	{
		itemMaster = GetComponent<Item_Master>();
		playerGo = GameManager_References._player;

		if (isTriggerPickup)
		{
			if (GetComponent<Collider>() != null)
			{
				GetComponent<Collider>().isTrigger = true;
			}

			if (GetComponent<Rigidbody>() != null)
			{
				GetComponent<Rigidbody>().isKinematic = true;
			}
		}
	}

	void TakeAmmo()
	{
		playerGo.GetComponent<Player_Master>().CallEventPickedUpAmmo(ammoName, quantity);
		Destroy(gameObject);
	}
}
