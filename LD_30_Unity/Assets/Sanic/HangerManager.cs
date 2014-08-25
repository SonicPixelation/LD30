using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class HangerManager : MonoBehaviour {


	private GameObject Center;


	void Start () 
	{
		Center = GameObject.Find ("Main Canvas/Center").gameObject;

	}


	void Update()
	{
		if(Center.GetComponent<PlanetInterface>().sun != null)
		{
			transform.GetComponent<Text>().text = "Number of Free Hangers: " + Center.GetComponent<PlanetInterface>().sun.GetComponent<SunHandler>().HangerSlots;
		}

	}
}
