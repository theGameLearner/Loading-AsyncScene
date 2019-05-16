using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOnCol : MonoBehaviour
{

	Material myMaterial;
	float red, green, blue;
	public Color myCol;
	void Start()
	{
		//create a new material using the material attached to the gameObject
		myMaterial = new Material(GetComponent<Renderer>().material);

		//change the material used by the game Object.
		//set the newly created material as the material used by this GameObject
		GetComponent<Renderer>().material = myMaterial;
	}

	void OnCollisionEnter(Collision colEvent)
	{
		//create random color
		red = Random.Range(0.2f, 0.8f);
		green = Random.Range(0.2f, 0.8f);
		blue = Random.Range(0.2f, 0.8f);
		myCol = new Color(red, green, blue);

		//assign random color to material
		myMaterial.color = myCol;
	}
}
