using UnityEngine;
using System.Collections;

public class Poderes : MonoBehaviour {

	public GameObject fbPrefab;
	public GameObject shield;
	private int cdFB = 0;
	private int cdSH = 0;

void FixedUpdate () {
	#region
	cdFB--;
	cdSH--;

	if (cdFB <= 0) {
		if (Input.GetKey(KeyCode.Alpha1)) {
			cdFB = 240;

			RaycastHit hit;
			Vector3 centro = new Vector3 (Screen.width / 2, Screen.height / 2);
			Ray raio = Camera.main.ScreenPointToRay (centro);
			Physics.Raycast (raio, out hit, 20);
				if (hit.transform) {
					Quaternion rotacaoFB = Quaternion.LookRotation(transform.forward);
					GameObject cloneFB = Instantiate(fbPrefab,transform.position, rotacaoFB) as GameObject;
					cloneFB.GetComponent<Rigidbody>().AddRelativeForce(0, 0, 2000);
					Destroy (cloneFB, 5);
				}
			}
		}
	#endregion
	
	#region
	if (cdSH <= 0) {
		if (Input.GetKey (KeyCode.Alpha2)) {
			cdSH = 480;
			shield.SetActive (true);
		}
	}
		if (cdSH <= 240) {
			shield.SetActive (false);
		}
	#endregion

	}
}

