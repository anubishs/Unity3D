using UnityEngine;
using System.Collections;

public class EnemyMov_1 : MonoBehaviour {

	public int rotateSpeed = 5;
	public int movementSpeed = 5;

	public int maxDistance = 2;
	public int minAttackRange =50;

	private Transform myTransform;
	public Transform target;

	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		GameObject go = GameObject.FindGameObjectWithTag ("Player");
		target = go.transform;

		rb = GetComponent<Rigidbody> ();

		myTransform = transform;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(Vector3.Distance (target.position, myTransform.position) > maxDistance && Vector3.Distance (target.position, myTransform.position) < minAttackRange) {
			MoveTowardsPlayer ();
		}
	}

	void MoveTowardsPlayer ()
	{
		Debug.DrawLine (myTransform.position, target.position, Color.red);
		//rotate enemy
		myTransform.rotation = Quaternion.Slerp (myTransform.rotation, Quaternion.LookRotation (target.position - myTransform.position), rotateSpeed * Time.deltaTime);
			//move
			//myTransform.position += myTransform.forward * movementSpeed * Time.deltaTime;
		rb.MovePosition(myTransform.position + myTransform.forward * movementSpeed * Time.deltaTime);


	}
}
