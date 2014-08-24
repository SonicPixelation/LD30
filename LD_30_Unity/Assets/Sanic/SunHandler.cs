using UnityEngine;
using System.Collections;

public class SunHandler : MonoBehaviour 
{
	public string name;

	public bool hasBase = false;

	public int HangerSlots = 0;

	public int Transport = 0;

	public int Cargo = 0;

	public int Tanker = 0;




	private Vector4 DefaultColor = new Vector4(1,1,1,1);
	private Vector4 OwnerShipColor = new Vector4(1,0,0,1);
	private Vector4 HoverColor = new Vector4(0,1,0,1);

	private GameObject mainCanvasCenter;

	public void Start()
	{
		mainCanvasCenter = GameObject.Find ("Main Canvas/Center").gameObject;
	}


	public void Hover()
	{
		Debug.Log("Hover");
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
		mainCanvasCenter.GetComponent<PlanetInterface>().sun = gameObject;
		mainCanvasCenter.GetComponent<PlanetInterface>().Enable();
	}


	public void buildBase()
	{
		hasBase = true;
		HangerSlots = 2;
	}
}
