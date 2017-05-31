using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cheats : MonoBehaviour {

	#region Variables
	public Player_Health Phealth;
	public GameObject tp1;
	public GameObject tp2;
	public GameObject tp3;
	public GameObject tp4;
	#endregion

	void Start () 
	{
		Phealth = GetComponent<Player_Health>();
	}
	
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.Alpha0))
		{
			Phealth.enabled = false;
		}
		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			gameObject.transform.position = tp1.transform.position;
		}
		if (Input.GetKeyDown(KeyCode.Alpha2))
		{
			gameObject.transform.position = tp2.transform.position;
		}
		if (Input.GetKeyDown(KeyCode.Alpha3))
		{
			gameObject.transform.position = tp3.transform.position;
		}
		if (Input.GetKeyDown(KeyCode.Alpha4))
		{
			gameObject.transform.position = tp4.transform.position;
		}
	}
}
