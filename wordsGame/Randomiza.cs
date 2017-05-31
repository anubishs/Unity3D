using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomiza : MonoBehaviour
	{
	public GameObject[] Prefabs;

	public List<Transform> t_Positions;

	void Awake()
	{
		for (int i = 0; i < t_Positions.Count; i++) 
		{
			Transform tmp = t_Positions [i];
			int a = (int)Random.Range (i, t_Positions.Count);
			t_Positions [i] = t_Positions [a];
			t_Positions [a] = tmp;
		}

		for (int i = 0; i < t_Positions.Count; i++) {
			GameObject a = Instantiate (Prefabs[i], t_Positions[i].position, Quaternion.identity) as GameObject;
		}
	}
}
