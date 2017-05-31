using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lookatcamera : MonoBehaviour {

    public Transform target;

	void Awake()
	{
		transform.LookAt(target);
	}

	// Update is called once per frame
	void Update () {
        transform.LookAt(target);
	}
}
