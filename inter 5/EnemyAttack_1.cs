using UnityEngine;
using System.Collections;

public class EnemyAttack_1 : MonoBehaviour {

	public float maxDistance;
	public float coolDownTimer;
	public PlayerHealth ph;
	public int damage;
	public int damage2;

	public Animator myAnim;

	private Transform myTransform;
	public Transform target;

	public GameObject shield;

	public bool imortal;

	// Use this for initialization
	void Start () {
		GameObject go = GameObject.FindGameObjectWithTag ("Player");
		target = go.transform;
		myTransform = transform;	
		maxDistance = 3;
		coolDownTimer = 0;

		imortal = false;

		ph = (PlayerHealth) go.GetComponent(typeof(PlayerHealth));
	}
	
	// Update is called once per frame
	void Update ()
	{
		float distance = Vector3.Distance (target.position, myTransform.position);
		if (distance < maxDistance) {
			myAnim.SetBool ("isAttacking", true);
			Attack ();
		} else {
			myAnim.SetBool ("isAttacking", false);
		}

		if (coolDownTimer > 0) {
			coolDownTimer = coolDownTimer - Time.deltaTime;
		}

		if (coolDownTimer < 0) {
			coolDownTimer = 0;
		}

		if (shield.activeSelf == true) {
			damage = 0;
		} else{
			damage = damage2;
		}

		if (Input.GetKeyDown (KeyCode.Keypad0)) {
			imortal = true;
		}
		if (Input.GetKeyDown (KeyCode.Keypad9)) {
			imortal = false;
		} 
	}

	void Attack ()
	{
		Vector3 dir = Vector3.Normalize (target.position - myTransform.position);
		float direction = Vector3.Dot (dir, transform.forward);
		if (direction > 0) {
			if (coolDownTimer == 0 && imortal == false) {
				ph.ChangeHealth (damage);
				coolDownTimer = 2;
			}
		}
	}
}
