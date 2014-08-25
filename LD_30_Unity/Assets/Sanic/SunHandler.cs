using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SunHandler : MonoBehaviour 
{
	public string name;

	public bool hasBase = false;

	public int HangerSlots = 0;

	public int Ships = 0;

	public int MoveableCargo = 0;

	public int MoveableHumans = 0;

	public GameObject Ship;


	private Vector4 DefaultColor = new Vector4(1,1,1,1);
	private Vector4 OwnerShipColor = new Vector4(1,0,0,1);
	private Vector4 HoverColor = new Vector4(0,1,0,1);

	private GameObject mainCanvasCenter;
	
	private GameObject HangerText;

	public void Start()
	{
		mainCanvasCenter = GameObject.Find ("Main Canvas/Center").gameObject;

	}

	private int tick;
	public void Update()
	{
		if(tick % 1000 == 0)
		{
			MoveableCargo += 1;
		}

		if(tick % 2000 == 0)
		{
			MoveableHumans += 1;
		}

		tick++;
	}

	
	public void Hover()
	{
		Transform trans = transform.FindChild("Selector").transform;
		trans.GetComponent<SpriteRenderer>().color = HoverColor;

		GameObject.Find("Main Canvas/Bottom/Planet_Name").GetComponent<Text>().text = name;
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

		GameObject.Find("Main Canvas/Bottom/Planet_Name").GetComponent<Text>().text = "";

	}

	public void OnTriggerStay2D(Collider2D collider)
	{
		if(collider.transform.tag == "Ship")
		{


			ShipController c = collider.GetComponent<ShipController>();

			if(new Vector2(c.getXTarget(),c.getYTarget()) == new Vector2(transform.position.x, transform.position.y) && (c.getCargo() > 0 || c.getPeople() > 0))
			{

				GameManager.addMoney(c.getCargo() * 10);
				GameManager.addMoney(c.getPeople() * 20);
				Ships += 1;
				if(HangerSlots <= 0)
				{
					GameManager.subMoney(1000);
				}
				else
				{
					HangerSlots -= 1;
				}
				Destroy(collider.gameObject);
			}
		}
	}

	public void Click()
	{
		if(!GameManager.selectionMode)
		{
			mainCanvasCenter.GetComponent<PlanetInterface>().sun = gameObject;
			mainCanvasCenter.GetComponent<PlanetInterface>().Enable();
		}
		else
		if(GameManager.selectionMode && hasBase && gameObject != mainCanvasCenter.GetComponent<PlanetInterface>().sun)
		{
			mainCanvasCenter.GetComponent<PlanetInterface>().targetSun = gameObject;
			mainCanvasCenter.GetComponent<PlanetInterface>().manageShips();
			GameManager.selectionMode = false;
		}
		else
		{
		}
	}



}
