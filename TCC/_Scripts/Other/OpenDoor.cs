using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour {

	#region Variables
	public GameObject door;
	public GameObject painelClosed1;
	public GameObject painelClosed2;
	public GameObject painelOpened1;
	public GameObject painelOpened2;
	public bool canOpen;
	public Vector3 openedPos;
	public Vector3 closedPos;
	public float spd;
	#endregion

	void Start()
	{
		canOpen = false;
		spd = 3 * Time.deltaTime;
	}

	void Update()
	{
		if (canOpen)
		{
			openMe();
			painelClosed1.SetActive(false);
			painelClosed2.SetActive(false);
			painelOpened1.SetActive(true);
			painelOpened2.SetActive(true);
		}
		else if (!canOpen)
		{
			closeMe();
			painelClosed1.SetActive(true);
			painelClosed2.SetActive(true);
			painelOpened1.SetActive(false);
			painelOpened2.SetActive(false);
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
