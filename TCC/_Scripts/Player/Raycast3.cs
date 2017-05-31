using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast3 : MonoBehaviour {

    public static float distance3 = 5;
    public RaycastHit hit;

    // Use this for initialization
    void Awake () {
		distance3 = hit.distance;
	}

    // Update is called once per frame
    void Update() {
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward),out hit))
        {
            distance3 = hit.distance;
        }
    }
}
