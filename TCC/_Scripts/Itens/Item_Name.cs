using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Name : MonoBehaviour {

	#region Variables
	public string itemName;
	#endregion

	void Start()
	{
		SetItemName();
	}

	void SetItemName()
	{
		transform.name = itemName;
	}
}
