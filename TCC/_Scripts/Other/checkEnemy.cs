using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkEnemy : MonoBehaviour {

	#region Variables
	public GameObject elevatorPanel;
	public GameObject elevatorfalse;
	public GameObject obj;
	#endregion

	void Update()
	{

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "enemy")
		{
			elevatorPanel.SetActive(true);
			elevatorfalse.SetActive(false);
			obj.SetActive(true);
		}
	}

	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "enemy")
		{
			elevatorPanel.SetActive(false);
			elevatorfalse.SetActive(true);
		}
	}
}
