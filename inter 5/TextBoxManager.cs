using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//using UnityStandardAssets.Characters.FirstPerson;

public class TextBoxManager : MonoBehaviour {

	public GameObject textBox;

	public Text theText;

	public TextAsset textFile;
	public string[] textLines;

	public int currentLine;
	public int endAtLine;

	public CharacterController Player;

	public bool isActive;

	public bool stopPlayerMov;


	// Use this for initialization
	void Start () {

		Player = GameObject.FindWithTag ("Player").GetComponent<CharacterController> ();

		if (textFile != null) 
		{
			textLines = (textFile.text.Split ('\n'));
		}

		if (endAtLine == 0) 
		{
			endAtLine = textLines.Length - 1;
		}

		if (isActive) {
			EnableTextBox ();
		} 
		else 
		{
			DisableTextBox ();
		}
	}

	void Update() {

		if (!isActive) 
		{
			return;
		}
	
		theText.text = textLines [currentLine];

		if (Input.GetKeyDown (KeyCode.Return))
		{
			currentLine += 1;
		}

		if (currentLine > endAtLine) 
		{
			DisableTextBox ();
		}

	}

	public void EnableTextBox()
	{
		textBox.SetActive (true);
		isActive = true;

		if (stopPlayerMov) 
		{
			Time.timeScale = 0;
			Player.enabled =false;


		}
	}

	public void DisableTextBox()
	{
		textBox.SetActive (false);
		isActive = false;
		Player.enabled = true;
		Time.timeScale = 1;
	}

	public void ReloadScript (TextAsset theText)
	{
		if(theText != null)
		{
			textLines = new string[1];
			textLines = (theText.text.Split ('\n'));
		}
	}
}

