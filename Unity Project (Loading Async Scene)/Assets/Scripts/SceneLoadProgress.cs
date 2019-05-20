using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoadProgress : MonoBehaviour
{
	public Slider progressBar;
	public Text ProgressText;
	
	void Start()
	{
		progressBar.gameObject.SetActive(false);
	}

	void Update()
	{
		if(Input.GetMouseButtonDown(0))
		{
			LoadNextScene();
		}
	}

	void LoadNextScene()
	{
		
		progressBar.gameObject.SetActive(true);
		//use the coroutine to load the scene with next builtIndex
		StartCoroutine(LoadNewScene());

	}

	IEnumerator LoadNewScene()
	{

		// Start an asynchronous operation to load the scene that was passed to the LoadNewScene coroutine.
		AsyncOperation async = SceneManager.LoadSceneAsync(
				(SceneManager.GetActiveScene().buildIndex + 1)
				%
				SceneManager.sceneCountInBuildSettings
		
		);

		// While the asynchronous operation to load the new scene is not yet complete, continue waiting until it's done.
		while (!async.isDone)
		{
			float progress = Mathf.Clamp01(async.progress / 0.9f);
			progressBar.value = progress;
			ProgressText.text = progress * 100f + "%";
			yield return null;
		}
	}
}
