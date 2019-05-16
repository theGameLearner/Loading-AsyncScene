using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StandardLoadScene : MonoBehaviour {

	void Update()
	{
		if(Input.GetMouseButtonDown(0))
		{
			SceneManager.LoadScene(
				//check current built index : SceneManager.GetActiveScene().buildIndex
				//add one to this to go to next scene
				//divide the number by scene count to get back to circular order
				(SceneManager.GetActiveScene().buildIndex + 1)
				%
				SceneManager.sceneCountInBuildSettings
				);
		}
	}
}
