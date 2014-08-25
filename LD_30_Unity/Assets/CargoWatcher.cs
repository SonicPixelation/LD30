using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CargoWatcher : MonoBehaviour {

	PlanetInterface PI;
	
	void Start () 
	{
		PI = GameObject.Find ("Main Canvas/Center").GetComponent<PlanetInterface>();
	}
	
	
	void Update () 
	{
		transform.GetComponent<Text>().text = ""+PI.getIntendedCargo();
	}
}
