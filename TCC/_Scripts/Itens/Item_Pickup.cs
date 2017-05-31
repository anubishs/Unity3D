using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Pickup : MonoBehaviour {

	#region Variables
	private Item_Master itemMatser;
	#endregion

	void OnEnable()
	{
		SetInitialReferences();
		itemMatser.EventPickupAction += CarryOutPickupActions;
	}

	void OnDisable()
	{
		itemMatser.EventPickupAction -= CarryOutPickupActions;
	}
	

	void SetInitialReferences()
	{
		itemMatser = GetComponent<Item_Master>();
	}

	void CarryOutPickupActions(Transform tParent)
	{
		tParent = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

		transform.SetParent(tParent);
		itemMatser.CallEventObjectPickup();
		transform.gameObject.SetActive(false);
	}
}
