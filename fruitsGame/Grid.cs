using UnityEngine;
using System.Collections;
using Mechanic;

public class Grid : MonoBehaviour {
	public GameObject[] Prefabs;
	public float gridWidth;
	public float gridHeight;


	GameObject[,] boardArray = new GameObject[7, 7];


	void Awake () 
	{
		GenerateGrid ();
	}

	void GenerateGrid()

	{
		for (int i = 0; i < boardArray.GetLength(1); i++) 
		{
			for (int j = 0; j < boardArray.GetLength (1); j++) 
			{
				int r = Random.Range (0, Prefabs.Length);
				boardArray [i, j] = Instantiate (Prefabs[r], new Vector3 (j * 1.25f, i * 1.25f, 0), Quaternion.identity) as GameObject;
			}
		}
	}
}