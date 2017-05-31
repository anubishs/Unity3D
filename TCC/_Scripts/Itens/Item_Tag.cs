using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Tag : MonoBehaviour {

	#region Variables
	public string itemTag;
	#endregion

	void OnEnable()
	{
		SetTag();
	}

	void SetTag()
	{
		if(itemTag != "")
		{
			itemTag = "Untagged";
		}

		transform.tag = itemTag;
	}
}
