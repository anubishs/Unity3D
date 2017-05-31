using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isThisAEnemy : MonoBehaviour {

    public GameObject PutTheLightHere;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "enemy")
        {
            PutTheLightHere.SetActive(true);
        } 
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "enemy")
        {
            PutTheLightHere.SetActive(false);
        }
    }
}
