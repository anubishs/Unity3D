using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Dropper_Coll_Test : MonoBehaviour {

    public Enemy_Detection detection;
    public Enemy_NavPursue persue;
    public Enemy_NavDestinationReached destination;
    public Enemy_NavWander wander;
    public NavMeshAgent nav;
    public Rigidbody rb;
    public CapsuleCollider cc;

    // Use this for initialization
    void Start ()
    {
        detection = GetComponent<Enemy_Detection>();
        persue = GetComponent<Enemy_NavPursue>();
        destination = GetComponent<Enemy_NavDestinationReached>();
        wander = GetComponent<Enemy_NavWander>();
        nav = GetComponent<NavMeshAgent>();
        rb = GetComponent<Rigidbody>();
        cc = GetComponent<CapsuleCollider>();
    }
	
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            rb.useGravity = true;
            cc.enabled = false;
            StartCoroutine(WaitASecond());
        }
    }

    IEnumerator WaitASecond()
    {
        yield return new WaitForSeconds(1);
        detection.enabled = true;
        persue.enabled = true;
        destination.enabled = true;
        wander.enabled = true;
        nav.enabled = true;
    }

    void DisableThis()
    {
        StopAllCoroutines();
    }
}
