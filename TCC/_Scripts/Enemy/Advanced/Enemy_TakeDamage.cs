using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_TakeDamage : MonoBehaviour {

	#region Variables
	private Enemy_Master enemyMaster;
	public int damageMultiplier = 1;
	public bool ShouldRemoveCollider;
	#endregion

	void OnEnable () 
	{
		SetInitialReferences();
		enemyMaster.EventEnemyDie += RemoveThis;
	}
	
	void OnDisable () 
	{
		enemyMaster.EventEnemyDie -= RemoveThis;
	}

	void SetInitialReferences()
	{
		enemyMaster = transform.root.GetComponent<Enemy_Master>();
	}

	public void ProcessDamage(int damage)
	{
		int damageToApply = damage * damageMultiplier;
		enemyMaster.CallEventEnemyDeductHealth(damageToApply);
	}

	void RemoveThis()
	{
		if (ShouldRemoveCollider)
		{
			if(GetComponent<Collider>() != null)
			{
				Destroy(GetComponent<Collider>());
			}
			if (GetComponent<Rigidbody>() != null)
			{
				Destroy(GetComponent<Rigidbody>());
			}
		}

		Destroy(this);
	}
}
