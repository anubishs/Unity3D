using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	[SerializeField]
	private Stat health;

	[SerializeField]
	private Stat mana;

	// Use this for initialization

	private void Awake()
	{
		health.Initialize ();
		mana.Initialize ();
	}

	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKeyDown (KeyCode.Q)) 
		{
			health.CurrentVal -= 10;
		}
		if (Input.GetKeyDown (KeyCode.E)) 
		{
			health.CurrentVal += 10;
		}
		if (Input.GetKeyDown (KeyCode.R)) 
		{
			mana.CurrentVal -= 10;
		}
		if (Input.GetKeyDown (KeyCode.T)) 
		{
			mana.CurrentVal += 10;
		}
	}
}
