using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;


public class AimPlayeController : MonoBehaviour {
    public Transform cam;
    public Transform jogador;
    public bool aimOn;

    private ThirdPersonCharacter playerControl;


    public void Awake()
    {
        playerControl = jogador.gameObject.GetComponent<ThirdPersonCharacter>();

    }

    public void LateUpdate()
    {
        if (Input.GetMouseButtonDown(1))
        {
            aimOn = true;
            playerControl.enabled = false;
        }

        if (Input.GetMouseButtonUp(1))
        {
            aimOn = false;
            playerControl.enabled = true;
        }

        if (aimOn)
        {

            float angle = cam.eulerAngles.y;
            var jogadorAngles = jogador.transform.eulerAngles;
            jogadorAngles.y = angle;
            jogador.transform.eulerAngles = jogadorAngles;
        }
    }


}
