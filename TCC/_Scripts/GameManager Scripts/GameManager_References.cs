using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_References : MonoBehaviour {

	#region Variables
	public string playerTag;
	public static string _playerTag;

	public string enemyTag;
	public static string _enemyTag;
	
	public static GameObject _player;
	#endregion

	void OnEnable()
	{
		if(playerTag == "")
		{
			Debug.LogWarning("please type playerTag in inspector.");
		}
		if (enemyTag == "")
		{
			Debug.LogWarning("please type playerTag in inspector.");
		}

		_playerTag = playerTag;
		_enemyTag = enemyTag;
		_player = GameObject.FindGameObjectWithTag(_playerTag);
	}
}
