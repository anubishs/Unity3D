using UnityEngine;
using System;
using System.Collections;
using TouchScript.Gestures;
using UnityEngine.SceneManagement;

public class PlayMe : MonoBehaviour {

    public int scene;
    public GameObject HUD;
    public GameObject Loading;

    // Use this for initialization
    
    public void onTouch()
    {
        HUD.SetActive(false);
        Loading.SetActive(true);
        gameObject.SetActive(false);
    }

}
