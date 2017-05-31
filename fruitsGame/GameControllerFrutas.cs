using UnityEngine;
using System.Collections;
using Mechanic;

public class GameControllerFrutas : MonoBehaviour
{

	public int imageNumber;

	public GameObject carambola;
	public GameObject laranja;
	public GameObject goiaba;
	public GameObject mamao;
	public GameObject melancia;
	public GameObject manga;
	public GameObject uva;

    public GameObject carambolaT;
    public GameObject laranjaT;
    public GameObject goiabaT;
    public GameObject mamaoT;
    public GameObject melanciaT;
    public GameObject mangaT;
    public GameObject uvaT;

    public GameObject frutos;
    public GameObject frutas;

	public AudioClip carambolaSom;
	public AudioClip laranjaSom;
	public AudioClip goiabaSom;
	public AudioClip mamaoSom;
	public AudioClip melanciaSom;
	public AudioClip mangaSom;
	public AudioClip uvaSom;

	void Awake()
	{
		imageNumber = Random.Range(1, 8);

		if (imageNumber == 1)
		{
            carambola.SetActive(true);
            carambolaT.SetActive(true);
            frutas.SetActive(true);
			AudioSource.PlayClipAtPoint (carambolaSom, Camera.main.transform.position);
            GetComponent<Puzzle_1_ControllerFrutas>().Carambola();

		}
		if (imageNumber == 2)
		{
			laranja.SetActive(true);
            laranjaT.SetActive(true);
            frutas.SetActive(true);
			AudioSource.PlayClipAtPoint (laranjaSom, Camera.main.transform.position);
            GetComponent<Puzzle_1_ControllerFrutas>().Laranja();
		}
		if (imageNumber == 3)
		{
            goiaba.SetActive(true);
            goiabaT.SetActive(true);
            frutas.SetActive(true);
			AudioSource.PlayClipAtPoint (goiabaSom, Camera.main.transform.position);
            GetComponent<Puzzle_1_ControllerFrutas>().Goiaba();
		}
		if (imageNumber == 4)
		{
            mamao.SetActive(true);
            mamaoT.SetActive(true);
            frutos.SetActive(true);
			AudioSource.PlayClipAtPoint (mamaoSom, Camera.main.transform.position);
            GetComponent<Puzzle_1_ControllerFrutas>().Mamao();
		}
		if (imageNumber == 5)
		{
			melancia.SetActive(true);
            melanciaT.SetActive(true);
            frutas.SetActive(true);
			AudioSource.PlayClipAtPoint (melanciaSom, Camera.main.transform.position);
            GetComponent<Puzzle_1_ControllerFrutas>().Melancia();
		}
		if (imageNumber == 6)
		{
            manga.SetActive(true);
            mangaT.SetActive(true);
            frutas.SetActive(true);
			AudioSource.PlayClipAtPoint (mangaSom, Camera.main.transform.position);
            GetComponent<Puzzle_1_ControllerFrutas>().Manga();
		}
		
		if (imageNumber == 7)
		{
			uva.SetActive(true);
            uvaT.SetActive(true);
            frutas.SetActive(true);
			AudioSource.PlayClipAtPoint (uvaSom, Camera.main.transform.position);
            GetComponent<Puzzle_1_ControllerFrutas>().Uva();
		}
	}
}

