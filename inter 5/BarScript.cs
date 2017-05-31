﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BarScript : MonoBehaviour {
	
	private float fillAmount;

	[SerializeField]
	private float LerpSpeed;

	[SerializeField]
	private Image content;

	public float MaxValue { get; set; }

	public float MaximumValeu = 100;

	[SerializeField]
	private Text valueText;

	[SerializeField]
	private Color fullColor;

	[SerializeField]
	private Color lowColor;

	[SerializeField]
	private bool lerpColors;

	public float Value
	{
		set
		{
			string[] tmp = valueText.text.Split (':');
			valueText.text = tmp[0] + ": " + value;
			fillAmount = Map (value, 0, MaximumValeu, 0, 1);
		}
	}

	// Use this for initialization
	void Start () 
	{
		if (lerpColors) 
		{
			content.color = fullColor;
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		HandleBar ();
	}

	private void HandleBar ()
	{
		if (fillAmount != content.fillAmount) 
		{
			content.fillAmount = Mathf.Lerp (content.fillAmount, fillAmount, Time.deltaTime * LerpSpeed);
		}
		if (lerpColors) 
		{
			content.color = Color.Lerp (lowColor, fullColor, fillAmount);
		}
	}

	private float Map (float value, float inMin, float inMax, float outMin, float outMax)
	{
		return (value - inMin) * (outMax - outMin) / (inMax - inMin) + outMin;
	}
}
