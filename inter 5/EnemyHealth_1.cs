using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyHealth_1 : MonoBehaviour {

	public int currentHealth;
	public int maximumHealth = 100;
	private float cdIce = 0;

	public float hbLength;

	public Slider mySlider;
	// Use this for initialization
	void Start () {
		currentHealth = maximumHealth;

		hbLength = Screen.width / 2;
	}

	// Update is called once per frame
	void Update () {
		ChangeHealth (0);
	}
	void FixedUpdate()
	{
		cdIce --;
	}

	void OnGUI (){
		//GUI.Box (new Rect (Screen.width / 2 - hbLength /2 + 250, 10, hbLength, 25), currentHealth + " / " + maximumHealth);
	}

	public void ChangeHealth (int health){
		currentHealth += health;
		mySlider.value = currentHealth;
		hbLength = (Screen.width / 2) * (currentHealth / (float)maximumHealth);
		if (currentHealth <= 0) {
		Dead();
		}
	}


	void OnTriggerEnter(Collider colider){

		if (colider.gameObject.tag == "PlayerTiro") {
		ChangeHealth(-10);
		}
		if (colider.gameObject.tag == "Fogo") {
		ChangeHealth(-30);
		}
	}

	void OnTriggerStay (Collider colider)
	{
		if (colider.gameObject.tag == "Gelo" && cdIce < 0) {
				ChangeHealth (-1);
		}
	}

	void Dead ()
	{
	Destroy(this.gameObject);
	}
}
