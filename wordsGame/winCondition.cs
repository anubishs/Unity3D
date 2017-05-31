using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class winCondition : MonoBehaviour {

	public TextColliders[] a;
	public int totalObjects;

    public int scene;
    public GameObject win;

	void Awake(){
        
	}
	// Use this for initialization
	void Start () {
		//Debug.Log (a);
		a = FindObjectsOfType<TextColliders> ();
		totalObjects = a.Length;
	}
	
	// Update is called once per frame
	public void MinusObjects () 
	{
		totalObjects--;
	}

	void Update(){
		if (totalObjects <= 0) {
            win.SetActive(true);
		}
	}
}
