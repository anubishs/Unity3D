using UnityEngine;
using System.Collections;

public class TextColliders : MonoBehaviour {

	public winCondition winCond;
    public AudioClip feedBack;
	public AudioClip errou;
	private Vector3 pos;
  
	void Awake(){
		winCond = FindObjectOfType<winCondition> ();
		pos = gameObject.transform.position;
	}
		
    void OnTriggerEnter2D(Collider2D other)
    {		
		if (other.gameObject.tag == gameObject.tag) {
			winCond.GetComponent<winCondition> ().MinusObjects ();
			gameObject.SetActive (false);
			AudioSource.PlayClipAtPoint (feedBack, Camera.main.transform.position);

		} else if (other.gameObject.tag != gameObject.tag) {
			AudioSource.PlayClipAtPoint (errou, Camera.main.transform.position);
			gameObject.transform.position = pos;
			Handheld.Vibrate ();
		}
    }
}
