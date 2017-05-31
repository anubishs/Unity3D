﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_CanvasHurt : MonoBehaviour {

	#region Variables
	public GameObject hurtCanvas;
	private Player_Master playerMaster;
	private float secondsTillHide = 2;
	#endregion

	void OnEnable()
	{
		SetInitialReferences();
		playerMaster.EventPlayerHealthDeduction += TurnOnHurtEffect;
	}

	void OnDisable()
	{
		playerMaster.EventPlayerHealthDeduction -= TurnOnHurtEffect;
	}

	void SetInitialReferences()
	{
		playerMaster = GetComponent<Player_Master>();
	}

	void TurnOnHurtEffect(int dummy)
	{
		if(hurtCanvas != null)
		{
			StopAllCoroutines();
			hurtCanvas.SetActive(true);
			StartCoroutine(ResetHurtCanvas());
		}
	}

	IEnumerator ResetHurtCanvas()
	{
		yield return new WaitForSeconds(secondsTillHide);
		hurtCanvas.SetActive(false);
	}
}
