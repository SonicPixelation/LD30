using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberOfShips : MonoBehaviour {


	private GameObject Canvas;

	void Start () 
	{
		Canvas = GameObject.Find("Main Canvas/Center").gameObject;
	}
	

	void Update () 
	{
		SunHandler sunhandler = null;
		if(Canvas.GetComponent<PlanetInterface>().sun != null)
		{
			sunhandler = Canvas.GetComponent<PlanetInterface>().sun.GetComponent<SunHandler>();
		}

		if(sunhandler != null)
		{
			string message = "You have " + sunhandler.Ships + " Ships in this solar system";
				transform.GetComponent<Text>().text = message;
		}
	}
}
