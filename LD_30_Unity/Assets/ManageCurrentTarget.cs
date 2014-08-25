using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ManageCurrentTarget : MonoBehaviour {

	private GameObject Center;


	void Start()
	{
		Center = GameObject.Find ("Main Canvas/Center").gameObject;
	}


	void Update () 
	{
		if(Center.GetComponent<PlanetInterface>().targetSun != null)
		{
			string name = Center.GetComponent<PlanetInterface>().targetSun.GetComponent<SunHandler>().name;

			transform.GetComponent<Text>().text = "Current Target: " + name;
		}
		else
		{
			
			transform.GetComponent<Text>().text = "Current Target: ";
		}


	}
}
