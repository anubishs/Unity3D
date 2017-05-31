using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevatorUp : MonoBehaviour {

	#region Variables
	public GameObject elevator;
	public bool canGo;
	public Vector3 openedPos;
	public Vector3 closedPos;
	public float spd;
	#endregion

	void Start()
	{
		spd = 1 * Time.deltaTime;
		canGo = false;

	}

	void Update()
	{
		if (canGo)
		{
			openMe();
		}
		else if (!canGo)
		{
			//closeMe();
		}
	}

	void OnTriggerStay(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			if (Input.GetKeyDown(KeyCode.E))
			{
				canGo = !canGo;
			}
		}
	}

	void openMe()
	{
		elevator.transform.position = Vector3.Lerp(elevator.transform.position, openedPos, spd);
	}

	void closeMe()
	{
		elevator.transform.position = Vector3.Lerp(elevator.transform.position, closedPos, spd);
	}
}
