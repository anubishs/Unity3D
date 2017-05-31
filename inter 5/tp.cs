using UnityEngine;
using System.Collections;

public class tp : MonoBehaviour {

	public GameObject tep1;
	public GameObject tep2;
	public GameObject tep3;
	public GameObject tep4;

	public float chance;
	public bool tp1cd = false;
	public bool tp2cd = false;
	public bool tp3cd = false;
	public bool tp4cd = false;

	public GameObject MOB1;
	public GameObject MOB2;
	public GameObject MOB3;
	//private float Timer;
	private int Cooldown1 = 60;
	private int Cooldown2 = 60;

	public int timer1 = 0;
	public int timer2 = 0;
	public int timer3 = 0;
	public int timer4 = 0;

	public GameObject spn1;
	public GameObject spn2;
	public GameObject spn3;
	public GameObject spn4;
	//public int bruxaLife;

	public GameObject vrautp1;
	public GameObject vrautp2;
	public GameObject vrautp3;

	void Start () 
	{
		transform.position = tep1.transform.position;




	}


	void FixedUpdate ()
	{
		if (tp1cd) {
			timer1--;
		}
		if (tp2cd) {
			timer2--;
		}
		if (tp3cd) {
			timer3--;
		}
		if (tp4cd) {
			timer4--;
		}

	}

	void OnTriggerEnter (Collider colisor)
	{       
		GameObject bruxinha = GameObject.Find ("Anim_Bruxa");
		EnemyHealth_3 bruxaLife = bruxinha.GetComponent<EnemyHealth_3> ();
		if (colisor.tag == "PlayerTiro") {
			chance = Random.Range (0, 100);
			if (bruxaLife.currentHealth <= 750 && bruxaLife.currentHealth >= 500) {
				if (timer2 >= 0) {
					vrautp1.SetActive(true);
					transform.position = tep2.transform.position;
					tp2cd = true;
					Instantiate (MOB2, spn1.transform.position, transform.rotation);
					Cooldown2 = 60;
					Instantiate (MOB1, spn2.transform.position, transform.rotation);
					Cooldown1 = 60;
					Instantiate (MOB3, spn4.transform.position, transform.rotation);
					Cooldown2 = 60;
					Instantiate (MOB1, spn3.transform.position, transform.rotation);
					Cooldown1 = 60;
				}
			} else if (chance < 50 && bruxaLife.currentHealth <= 500 && bruxaLife.currentHealth >= 250) {
				if (timer4 >= 0) {
					vrautp2.SetActive(true);
					transform.position = tep4.transform.position;
					tp4cd = true;
					Instantiate (MOB2, spn1.transform.position, transform.rotation);
					Cooldown2 = 60;
					Instantiate (MOB1, spn2.transform.position, transform.rotation);
					Cooldown1 = 60;
					Instantiate (MOB3, spn4.transform.position, transform.rotation);
					Cooldown2 = 60;
					Instantiate (MOB1, spn3.transform.position, transform.rotation);
					Cooldown1 = 60;
				}
			} else if (chance < 75 && bruxaLife.currentHealth <= 250 && bruxaLife.currentHealth >= 0) {
				if (timer3 >= 0) {
					vrautp3.SetActive(true);
					transform.position = tep3.transform.position;
					tp3cd = true;
					Instantiate (MOB2, spn1.transform.position, transform.rotation);
					Cooldown2 = 60;
					Instantiate (MOB1, spn2.transform.position, transform.rotation);
					Cooldown1 = 60;
					Instantiate (MOB3, spn4.transform.position, transform.rotation);
					Cooldown2 = 60;
					Instantiate (MOB1, spn3.transform.position, transform.rotation);
					Cooldown1 = 60;
				}
			}
//			} else if (chance >= 75 && bruxaLife.currentHealth >= 750) {
//				if (timer1 >= 0) {				    				
//					transform.position = tep1.transform.position;
//					tp1cd = true;
//					Instantiate (MOB2, spn1.transform.position, transform.rotation);
//					Cooldown2 = 60;
//					Instantiate (MOB1, spn2.transform.position, transform.rotation);
//					Cooldown1 = 60;
//					Instantiate (MOB2, spn4.transform.position, transform.rotation);
//					Cooldown2 = 60;
//					Instantiate (MOB1, spn3.transform.position, transform.rotation);
//					Cooldown1 = 60;
//				}
//			}
		}

	}

}

