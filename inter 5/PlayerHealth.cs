using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

	public float currentHealth;
	public float maximumHealth = 100;

	public int currentMana;
	public int maximumMana = 200;

	public GameObject shield;

	public float hbLength1;
	public float hbLength2;

	public int cdLife = 600;
	public Slider vidaJogador;

	public int lifes = 6;
	public GameObject jogador;
	public GameObject respawn1;
	public GameObject respawn2;
	public GameObject respawn3;
	public GameObject respawn4;
	public GameObject respawn5;


	public bool rp1;
	public bool rp2;
	public bool rp3;
	public bool rp4;
	public bool rp5;

	public GameObject laser;

	public bool imortal;
	// Use this for initialization
	void Start () {
		currentHealth = maximumHealth;


		hbLength1 = Screen.width / 4;
		hbLength2 = Screen.width / 4;
		rp1 = true;
		rp2 = false;
		rp3 = false;
		rp4 = false;
		rp5 = false;
		imortal = false;


	}

	// Update is called once per frame
	void Update ()
	{
		ChangeHealth (0);
		ChangeMana (0);

		//if (Input.GetKeyDown (KeyCode.Keypad0)) {
		//	currentHealth = maximumHealth;
		//}
		if (Input.GetKeyDown(KeyCode.Keypad1)){
		jogador.transform.position = respawn1.transform.position;
		}
		if (Input.GetKeyDown(KeyCode.Keypad2)){
			jogador.transform.position = respawn2.transform.position;
		}
		if (Input.GetKeyDown(KeyCode.Keypad3)){
			jogador.transform.position = respawn3.transform.position;
		}
		if (Input.GetKeyDown(KeyCode.Keypad4)){
			jogador.transform.position = respawn4.transform.position;
		}
		if (Input.GetKeyDown(KeyCode.Keypad5)){
			jogador.transform.position = respawn5.transform.position;
		}
		if (Input.GetKeyDown (KeyCode.Keypad0)) {
			imortal = true;
		} 
		if (Input.GetKeyDown (KeyCode.Keypad9)) {
			imortal = false;
		} 

	}

	void FixedUpdate ()
	{
		cdLife--;

		if (cdLife <= 0) {
			currentHealth += 1;
		}
		if (Input.GetKeyDown (KeyCode.Alpha1) || Input.GetKeyDown (KeyCode.Alpha2) || Input.GetKeyDown (KeyCode.Alpha3) || Input.GetKeyDown (KeyCode.Alpha4) || Input.GetKey (KeyCode.Mouse0)) {
			cdLife = 600;
		}

		if (currentHealth > 100) {
			currentHealth = 100;
		}
	}

	void OnGUI (){
		//GUI.Box (new Rect (10, 30, hbLength1, 25)," Vida " + currentHealth + " / " + maximumHealth);
		//GUI.Box (new Rect(10,  60, hbLength2, 25),"Mana " + currentMana + " / " + maximumMana);
	}

	public void ChangeHealth (float health)
	{
		currentHealth += health;
		vidaJogador.value = currentHealth;
		hbLength1 = (Screen.width / 4) * (currentHealth / (float)maximumHealth);
		if (currentHealth <= 0) {
		Respawn();
		}
	}

	public void ChangeMana(int mana){
		currentMana += mana;
		hbLength2 = (Screen.width / 4) * (currentMana / (float)maximumMana);
	}

//	void OnColisionEnter (Collision colisor)
//	{
//		if (colisor.gameObject.tag == "TiroTag" && shield.activeInHierarchy == false) {
//			ChangeHealth (-10);
//		} else {
//			ChangeHealth (0);
//		}
//
//	}
	void OnTriggerEnter (Collider colider)
	{
		if (colider.gameObject.tag == "Morte") {
		Respawn();
		}
		if (colider.gameObject.tag == "TiroTag" && shield.activeInHierarchy == false && imortal == false) {
			ChangeHealth (-10);
		} else {
			ChangeHealth (0);
		}
		if (colider.gameObject.tag == "L_Arm" && shield.activeInHierarchy == false && imortal == false) {
			ChangeHealth (-30);
		} else {
			ChangeHealth (0);
		}
		if (colider.gameObject.tag == "R_Arm" && shield.activeInHierarchy == false && imortal == false) {
			ChangeHealth (-30);
		} else {
			ChangeHealth (0);
		}

	}
	void OnTriggerStay (Collider colider)
	{
		if (colider.gameObject.tag == "nextLevel" && Input.GetKeyDown (KeyCode.E)) {
		Application.LoadLevel(5);
		}

		if (colider.gameObject.tag == "DanoLaser" && laser.activeInHierarchy) {
			ChangeHealth (-0.3f);
		}

	}

	void OnTriggerExit (Collider colider)
	{
		if (colider.gameObject.tag == "respawn2") {
		rp1 = false;
		rp2 = true;
		}
		if (colider.gameObject.tag == "respawn3"){
		rp2 = false;
		rp3 = true;
		}
		if (colider.gameObject.tag == "respawn4"){
		rp3 = false;
		rp4 = true;
		}
		if (colider.gameObject.tag == "respawn5"){
		rp4 = false;
		rp5 = true;
		}
	}

	void Respawn ()
	{
		lifes--;
		currentHealth = maximumHealth;
		if (rp1 == true) {
			jogador.transform.position = respawn1.transform.position;
		}
		 else if (rp2 == true) {
			jogador.transform.position = respawn2.transform.position;
		} else if (rp3) {
			jogador.transform.position = respawn3.transform.position;
		}
		else if (rp4) {
			jogador.transform.position = respawn4.transform.position;
		}
		else if (rp5) {
			jogador.transform.position = respawn5.transform.position;
		}

		if (lifes <= 0){
		Dead();
		}
	}

	void Dead ()
	{
	Application.LoadLevel(2);
	//Destroy(this.gameObject);
	Debug.Log ("You Died");
	}
		
				
}
