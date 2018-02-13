using UnityEngine;
using System.Collections;

public class ForEach : MonoBehaviour {

	string[] animales = { "perro", "gato", "mamut"};

	void Start () 
	{
		foreach (string animal in animales)
		{
			Debug.Log(animal);
		}
	}

}
