using UnityEngine;
using System.Collections;

public class SumasYRestasScript : MonoBehaviour {


	string saludo = "Hola mi nombre es: ";
	string nombre = "Diego";

	int a = 11;
	int b = 2;


	void Start()
	{
		Debug.Log (a / b + "Suma");
		Debug.Log (a % b);
		Debug.Log (++a);
		Debug.Log (--a);
		Debug.Log (saludo + nombre);
		Debug.Log ("Hola " + nombre + " " + "que tal estas");
	}


}
