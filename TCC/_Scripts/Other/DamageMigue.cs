using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageMigue : MonoBehaviour {

	#region Variables
	public Enemy_Attack enemyAttack;
	#endregion

	void Start()
	{
		enemyAttack = GetComponent<Enemy_Attack>();
	}

	void OnCollisionEnter (Collision other) 
	{
		if (other.gameObject.tag == "Player")
		{
			enemyAttack.GetComponent<Enemy_Attack>().OnEnemyAttack();
		}
	}
	
	
}
