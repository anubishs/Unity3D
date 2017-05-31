using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadingBall : MonoBehaviour {

    public int scene;

	// Use this for initialization
	void Start () {
        StartCoroutine(LoadNewScene());
    }
	
	// Update is called once per frame
	void Update () {
	
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
