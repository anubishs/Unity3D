using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Health : MonoBehaviour {

	#region Variables
	private Enemy_Master enemyMaster;
	public int enemyHealth = 100;
	#endregion

	void OnEnable () 
	{
		SetInitialReferences();
		enemyMaster.EventEnemyDeductHealth += DeductHealth;
	}
	
	void OnDisable () 
	{
		enemyMaster.EventEnemyDeductHealth -= DeductHealth;
	}

	void SetInitialReferences()
	{
		enemyMaster = GetComponent<Enemy_Master>();
	}

	void DeductHealth(int healthChange)
	{
		enemyHealth -= healthChange;
		if(enemyHealth <= 0)
		{
			enemyHealth = 0;
			enemyMaster.CallEventEnemyDie();
			Destroy(gameObject, Random.Range(10, 20));
		}
	}
}
