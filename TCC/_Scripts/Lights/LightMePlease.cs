using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightMePlease : MonoBehaviour {

    public Light ligh;

	// Use this for initialization
	void Start ()
    {
        ligh = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (this.enabled == true)
        {
            ligh.enabled = true;
        } else if (this.enabled == false)
        {
            ligh.enabled = false;
        }
    }
}
