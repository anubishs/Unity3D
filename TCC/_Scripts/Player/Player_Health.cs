using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Health : MonoBehaviour {

	#region Variables
	private GameManager_Master gameManagerMaster;
	private Player_Master playerMaster;
	public int playerHealth;
	public Slider healthSlider;
	#endregion

	void OnEnable()
	{
		SetInitialReferences();
		SetUI();
		playerMaster.EventPlayerHealthDeduction += DeductHealth;
		playerMaster.EventPlayerHealthIncrease += IncreaseHealth;
	}

	void OnDisable()
	{
		playerMaster.EventPlayerHealthDeduction -= DeductHealth;
		playerMaster.EventPlayerHealthIncrease -= IncreaseHealth;
	}

	void Start () 
	{
		//StartCoroutine(TestHealthDeduction());
	}

	void SetInitialReferences()
	{
		gameManagerMaster = GameObject.Find("GameManager").GetComponent<GameManager_Master>();
		playerMaster = GetComponent<Player_Master>();
	}

	IEnumerator TestHealthDeduction()
	{
		yield return new WaitForSeconds(2);
		//DeductHealth(100);
		playerMaster.CallEventPlayerHealthDeduction(20);
	}

	void DeductHealth(int healthChange)
	{
		playerHealth -= healthChange;

		if (playerHealth <= 0)
		{
			playerHealth = 0;
			gameManagerMaster.CallEventGameOver();
		}

		SetUI();
	}

	void IncreaseHealth(int healthChange)
	{
		playerHealth += healthChange;

		if(playerHealth > 100)
		{
			playerHealth = 100;
		}

		SetUI();
	}

	void SetUI()
	{
		if(healthSlider != null)
		{
			healthSlider.value = playerHealth;
		}
	}
}
