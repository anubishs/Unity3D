using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_DetectItem : MonoBehaviour {

	#region Variables
	[Tooltip("Layer dos itens")]
	public LayerMask layerToDetect;
	[Tooltip("de onde vai sair o ray")]
	public Transform rayTransformPivot;
	[Tooltip("o botão que vai pegar os itens")]
	public string buttonPickUp;

	private Transform ItemAvailableForPickup;
	private RaycastHit hit;
	private float detectRange = 3;
	private float detectRadius = 0.7f;
	private bool itemInRange;

	private float labelWidth = 200;
	private float labelHeight = 50;
	#endregion

	void Update () 
	{
		CastRayForDetectingItens();
		CheckForItemPickupAttempt();
	}

	void CastRayForDetectingItens()
	{
		if(Physics.SphereCast(rayTransformPivot.position,detectRadius,rayTransformPivot.forward,out hit, detectRange, layerToDetect))
		{
			ItemAvailableForPickup = hit.transform;
			itemInRange = true;
		}
		else
		{
			itemInRange = false;
		}
	}

	void CheckForItemPickupAttempt()
	{
		if(Input.GetButtonDown(buttonPickUp) && Time.timeScale > 0 && itemInRange && ItemAvailableForPickup.root.tag != GameManager_References._playerTag)
		{
			//Debug.Log("Pickup attempted");
			ItemAvailableForPickup.GetComponent<Item_Master>().CallEventPickupAction(rayTransformPivot);
		}
	}

	void OnGUI()
	{
		if(itemInRange && ItemAvailableForPickup != null)
		{
			GUI.Label(new Rect(Screen.width / 2 - labelWidth  / 2, Screen.height / 2 + labelHeight, labelWidth, labelHeight),"Press E to pick up " + ItemAvailableForPickup.name);
		}
	}
}
