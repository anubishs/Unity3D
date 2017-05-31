using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeSceneForMenu : MonoBehaviour {


    public int scene;

    public GameObject HUD;
    public GameObject Loading;
    public GameObject fundo;
    public GameObject costurando;
    public GameObject mundinho;

    public void Change()
    {
        StartCoroutine(LoadNewScene());
        HUD.SetActive(false);
        fundo.SetActive(false);
        mundinho.SetActive(false);
        Loading.SetActive(true);
        costurando.SetActive(true);
    }

    IEnumerator LoadNewScene()
    {
        yield return new WaitForSeconds(3);

        AsyncOperation async = SceneManager.LoadSceneAsync(scene);

        while (!async.isDone)
        {
            yield return null;
        }
    }
}
