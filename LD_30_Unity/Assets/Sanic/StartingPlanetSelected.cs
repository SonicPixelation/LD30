using UnityEngine;
using System.Collections;

public class StartingPlanetSelected : MonoBehaviour {


	void Update () 
	{
		if(GameManager.startingPlanetSelected)
		{
			Destroy(gameObject);
		}
	}
}
