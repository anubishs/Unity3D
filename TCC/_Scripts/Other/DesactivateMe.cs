using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesactivateMe : MonoBehaviour {

	#region Variables
	#endregion

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
			gameObject.SetActive(false);
		}
	}
}
