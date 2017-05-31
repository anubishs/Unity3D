using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Puzzle_1_ControllerFrutas : MonoBehaviour {

	public string cuboCerto;
	public int totalCubes;
	private GameObject[] a;

    public int scene;
    public GameObject win;

	// Use this for initialization
	void Start () {
		a = GameObject.FindGameObjectsWithTag (cuboCerto);
		totalCubes = a.Length;

	
	}
	
	// Update is called once per frame
	void Update() {
		/*
		if (Input.GetMouseButtonDown(0)){
			RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

			if(hit && hit.collider.tag == cuboCerto){
				hit.transform.gameObject.GetComponent<OnCLick> ().setActivate ();
                totalCubes--;
			}
		}
		*/

        if (totalCubes <= 0)
        {
            win.SetActive(true);
        }
	}

	public void AttCubes()
	{
		totalCubes --;
	}

    public void Carambola()
    {
        cuboCerto = "carambola";
    }
    public void Laranja()
    {
        cuboCerto = "laranja";
    }
    public void Goiaba()
    {
        cuboCerto = "goiaba";
    }
    public void Mamao()
    {
        cuboCerto = "mamao";
    }
	public void Melancia()
	{
		cuboCerto = "melancia";
	}
	public void Manga()
	{
		cuboCerto = "manga";
	}
	public void Uva()
	{
		cuboCerto = "uva";
	}
}