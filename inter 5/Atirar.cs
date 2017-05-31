using UnityEngine;
using System.Collections;

public class Atirar : MonoBehaviour
{
	public GameObject atkPrefab;

	private int resfriamento = 0;
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		resfriamento--;

		if (resfriamento <= 0) {
			if (Input.GetAxis ("Fire1") > 0) {
				resfriamento = 20;


				RaycastHit hit;
				Vector3 centro = new Vector3 (Screen.width / 2, Screen.height / 2);
				Ray raio = Camera.main.ScreenPointToRay (centro);
				//Debug.DrawRay(raio.origin, raio.direction * 20, Color.cyan);
				Physics.Raycast (raio, out hit, 20);
				if (hit.transform) {
					Quaternion rotacaoATK = Quaternion.LookRotation(transform.forward);
					GameObject cloneATK = Instantiate(atkPrefab,transform.position, rotacaoATK) as GameObject;
					cloneATK.GetComponent<Rigidbody>().AddRelativeForce(0, 0, 4000);
					Destroy (cloneATK, 5);

					/*if (hit.transform.tag == "InimigoTag") {
						hit.transform.SendMessage ("Dano");
					*/
					}
				}
			}
		}
	}
