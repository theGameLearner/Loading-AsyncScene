using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManuallyDelayNewSceneLoad : MonoBehaviour 
{
	public int a = 50;
	public int b = 200;
	GameObject cubes, spheres;
	
	void Awake()
	{
		Method03();
	}
	
	void Start()
	{
		 Method01();
	}
	
	
	void Method01()
	{
		if(a >= 0)
		{
			cubes = GameObject.CreatePrimitive(PrimitiveType.Cube);
			a--;
			Method02();
		}
		else if(cubes)
			Destroy(cubes);
	}
	
	void Method02()
	{
		if(a >= 0)
		{
			Destroy(cubes);
			a--;
			Method01();
		}
		else if(cubes)
			Destroy(cubes);
	}
	
	void Method03()
	{
		if(b >= 0)
		{
			spheres = GameObject.CreatePrimitive(PrimitiveType.Sphere);
			b--;
			Method04();
		}
		else if(spheres)
			Destroy(spheres);
	}
	
	void Method04()
	{
		if(b >= 0)
		{
			Destroy(spheres);
			b--;
			Method03();
		}
		else if(spheres)
			Destroy(spheres);
	}
}
