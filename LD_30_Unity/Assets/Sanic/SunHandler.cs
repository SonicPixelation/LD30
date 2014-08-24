using UnityEngine;
using System.Collections;

public class SunHandler : MonoBehaviour 
{
	public string name;

	public bool hasBase = false;

	private Vector4 DefaultColor = new Vector4(1,1,1,1);
	private Vector4 OwnerShipColor = new Vector4(1,0,0,1);
	private Vector4 HoverColor = new Vector4(0,1,0,1);

	public void Hover()
	{
		Transform trans = transform.FindChild("Selector").transform;
		trans.GetComponent<SpriteRenderer>().color = HoverColor;
	}

	public void Default()
	{
		Transform trans = transform.FindChild("Selector").transform;

		if(!hasBase)
		{
			trans.GetComponent<SpriteRenderer>().color = DefaultColor;
		}
		else
		{
			trans.GetComponent<SpriteRenderer>().color = OwnerShipColor;
		}

	}


	public void Click()
	{
		if(!hasBase && !GameManager.startingPlanetSelected)
		{
			GameManager.startingPlanetSelected = true;
			hasBase = true;
		}
		else
		if(hasBase)
		{

		}
		else
		if(!hasBase && GameManager.startingPlanetSelected)
		{

		}

	}
}
