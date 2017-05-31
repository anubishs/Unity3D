using UnityEngine;
using System.Collections;

public class PlayTheSound : MonoBehaviour {

    public AudioClip win;
    public int time;

	// Use this for initialization
	void Start () {
        StartCoroutine(PlaySound());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator PlaySound()
    {
        yield return new WaitForSeconds(time);
        AudioSource.PlayClipAtPoint(win, Camera.main.transform.position);
    }
}
