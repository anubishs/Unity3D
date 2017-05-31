using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun_StandardInput : MonoBehaviour {

	#region Variables
	private Gun_Master gunMaster;
	private float nextAttack;
	public float attackRate = 0.5f;
	private Transform myTransform;
	public string attackButtonName;
	public string aimButtonName;
	public string reloadButtonName;
	#endregion

	void Start () 
	{
		SetInitialReferences();
	}
	
	void Update () 
	{
		CheckIfWeaponShouldAttack();
		CheckForReloadRequest();
	}

	void SetInitialReferences()
	{
		gunMaster = GetComponent<Gun_Master>();
		myTransform = transform;
		gunMaster.isGunLoaded = true;
	}

	void CheckIfWeaponShouldAttack()
	{
		if(Time.time > nextAttack && Time.timeScale > 0 && myTransform.root.CompareTag(GameManager_References._playerTag))
		{
			if (Input.GetButton(aimButtonName) && Input.GetButtonDown(attackButtonName))
			{
				AttemptAttack();
			}
		}
	}

	void AttemptAttack()
	{
		nextAttack = Time.time + attackRate;
		if (gunMaster.isGunLoaded)
		{
			Debug.Log("Shooting");
			gunMaster.CallEventPlayerInput();
		}
		else
		{
			gunMaster.CallEventGunNotUsable();
		}
	}

	void CheckForReloadRequest()
	{
		if(Input.GetButtonDown(reloadButtonName) && Time.timeScale > 0 && myTransform.root.CompareTag(GameManager_References._playerTag))
		{
			gunMaster.CallEventRequestReload();
		}
	}
}
