using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillMeProto: MonoBehaviour {

	#region Variables
	#endregion

	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.tag == "enemy")
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}
}
