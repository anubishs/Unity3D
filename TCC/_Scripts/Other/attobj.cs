using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attobj : MonoBehaviour {

	#region Variables
	public GameObject obj;
	#endregion

	void Start () 
	{
		
	}
	
	void Update () 
	{
		
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
			obj.SetActive(true);
			Destroy(this);
		}
	}
}
