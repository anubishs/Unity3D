using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun_Shoot : MonoBehaviour {

	#region Variables
	private Gun_Master gunMaster;
	private Transform myTransform;
	private Transform gunTransform;
	private RaycastHit hit;
	public float range = 400;
	//private Vector3 startPosition;
	#endregion

	void OnEnable () 
	{
		SetInitialReferences();
		gunMaster.EventPlayerInput += OpenFire;
	}
	
	void OnDisable () 
	{
		gunMaster.EventPlayerInput -= OpenFire;
	}

	void SetInitialReferences()
	{
		gunMaster = GetComponent<Gun_Master>();
		myTransform = transform;
		gunTransform = myTransform;
	}

	void OpenFire()
	{
		Debug.Log("Open fire called");
		if (Physics.Raycast(gunTransform.position, gunTransform.right, out hit, range))
		{
			gunMaster.CallEventShotDefault(hit.point, hit.transform);
			if (hit.transform.CompareTag(GameManager_References._enemyTag))
			{
				Debug.Log("shot enemy");
				gunMaster.CallEventShotEnemy(hit.point, hit.transform);
			}
		}
	}
}
