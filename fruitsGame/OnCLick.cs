using UnityEngine;
using System;
using System.Collections;
using TouchScript.Gestures;

public class OnCLick : MonoBehaviour 
{
    public AudioClip feedbackPositivo;
    public AudioClip feedbackNegativo;
    public Puzzle_1_ControllerFrutas s;

	public bool up;
	public float timer = 5;
	Vector3 posicao;

	void Awake()
	{
		s = FindObjectOfType<Puzzle_1_ControllerFrutas> ();
		posicao = transform.position;
	}

	void FixedUpdate(){
		if (timer <= 1) {
			if (up) {
				transform.Translate (0.1f, 0, 0);
				up = false;
			} else {
				transform.Translate (-0.1f, 0, 0);
				up = true;
			}
			timer += Time.deltaTime;
		} else if (timer > 1) {
			transform.position = posicao;
		}
	}

	private void OnEnable()
	{
		// subscribe to gesture's Tapped event
		GetComponent<TapGesture>().Tapped += tappedHandler;
	}

	private void OnDisable()
	{
		// don't forget to unsubscribe
		GetComponent<TapGesture>().Tapped -= tappedHandler;
	}

	private void tappedHandler(object sender, EventArgs e)
	{

		if (gameObject.tag == s.cuboCerto) {
			setActivate ();
			s.AttCubes();

		} else if (gameObject.tag != s.cuboCerto)
        {
            AudioSource.PlayClipAtPoint(feedbackNegativo, Camera.main.transform.position);
			timer = 0;
			Handheld.Vibrate ();
		}
     }

	public void setActivate() {
        AudioSource.PlayClipAtPoint(feedbackPositivo, Camera.main.transform.position);
		gameObject.SetActive(false);
	}
}
