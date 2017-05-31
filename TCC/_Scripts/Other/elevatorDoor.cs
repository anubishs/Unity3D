using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevatorDoor : MonoBehaviour {

	#region Variables
	public GameObject door;
	public bool canOpen;
	public Vector3 openedPos;
	public Vector3 closedPos;
	public float spd;
	#endregion

	void Start()
	{
		spd = 1 * Time.deltaTime;
		canOpen = false;
		
	}

	void Update()
	{
		if (canOpen)
		{
			openMe();
		}
		else if (!canOpen)
		{
			closeMe();
		}
	}

	void OnTriggerStay(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			if (Input.GetKeyDown(KeyCode.E))
			{
				canOpen = !canOpen;
			}
		}
	}

	void openMe()
	{
		door.transform.position = Vector3.Lerp(door.transform.position, openedPos, spd);
	}

	void closeMe()
	{
		door.transform.position = Vector3.Lerp(door.transform.position, closedPos, spd);
	}
}
