using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameovertest : MonoBehaviour {

	#region Variables
	#endregion

	void Start () 
	{
		
	}
	
	void Update () 
	{
		if (Input.GetKeyUp(KeyCode.T))
		{
			GetComponent<GameManager_Master>().CallEventGameOver();
		}
	}
}
