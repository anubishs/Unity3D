using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LightsOutYouWin : MonoBehaviour {

	#region Variables
	
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
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}
}
