using UnityEngine;
using System.Collections;

public class MobSpawn1 : MonoBehaviour {
	public GameObject MOB1;
	public GameObject MOB2;
	private float Timer;
	private int Cooldown1 = 60;
	private int Cooldown2 = 60;

	void Awake () {
		Timer = Time.time + 3;
	}

	// Update is called once per frame
	void Update () {
		Cooldown1--;
		Cooldown2--;
		if (Input.GetKey(KeyCode.Alpha5) && Cooldown1 <= 0) {
			Instantiate (MOB1, transform.position, transform.rotation);
			Cooldown1 = 60;
		}
		if (Input.GetKey(KeyCode.Alpha6) && Cooldown2 <= 0) {
			Instantiate (MOB2, transform.position, transform.rotation);
			Cooldown2 = 60;
		}
	}
}
