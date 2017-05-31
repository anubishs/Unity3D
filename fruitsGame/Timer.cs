using System;
using System.Collections;
using UnityEngine;

public class Timer : MonoBehaviour
{
	void Start()
	{
		StartCoroutine (A ());
	}

	IEnumerator A()
	{
		yield return new WaitForSeconds (3f);
		gameObject.SetActive (false);
	}
}