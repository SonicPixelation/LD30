using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class PlanetInterface : MonoBehaviour {

	public GameObject sun;

	public GameObject targetSun;

	public GameObject ShipPrefab;

	private bool Back = false;

	private Text PlanetName;




	public void Start()
	{
		Disable();
		PlanetName = transform.FindChild("Always_Activate/Planet_Name").GetComponent<Text>();
	}



	void Update () 
	{
		if(sun != null)
		{
			PlanetName.text = sun.GetComponent<SunHandler>().name + "\n" + 
				sun.GetComponent<SunHandler>().MoveableCargo + " :Moveable Cargo \n" + 
				sun.GetComponent<SunHandler>().MoveableHumans + " :Moveable People";
		}



	}


	public void Disable()
	{
		transform.GetComponent<Image>().enabled = false;
		foreach(UIGroupManager c in transform.GetComponentsInChildren<UIGroupManager>())
		{
			c.Disable();
		}
	}

	public void Enable()
	{
		transform.GetComponent<Image>().enabled = true;
		transform.FindChild("Always_Activate").GetComponent<UIGroupManager>().Enable();

		if(!sun.GetComponent<SunHandler>().hasBase)
		{
			transform.FindChild("Found").GetComponent<UIGroupManager>().Enable();
		}
		else
		{
			transform.FindChild("StartingMenu").GetComponent<UIGroupManager>().Enable();
		}
	}

	public void HandleBack()
	{
		if(!Back)
		{
			Disable();
		}
		else
		{
			Disable();
			Enable();
			targetSun = null;
			IntendedCargo = 0;
			IntendedPeople = 0;
			Back = false;

		}
	}

	public void buyUpgrades()
	{
		Disable();
		transform.GetComponent<Image>().enabled = true;
		transform.FindChild("Always_Activate").GetComponent<UIGroupManager>().Enable();

		transform.FindChild("UpgradesMenu").GetComponent<UIGroupManager>().Enable();

		Back = true;
	}

	public void buyShips()
	{
		Disable();
		transform.GetComponent<Image>().enabled = true;
		transform.FindChild("Always_Activate").GetComponent<UIGroupManager>().Enable();


		transform.FindChild("BuyShips").GetComponent<UIGroupManager>().Enable();

		Back = true;
	}

	public void manageShips()
	{
		Disable();
		transform.GetComponent<Image>().enabled = true;
		transform.FindChild("Always_Activate").GetComponent<UIGroupManager>().Enable();

		transform.FindChild("ManageShips").GetComponent<UIGroupManager>().Enable();


		Back = true;
	}



	//other
	public void buildBase()
	{
		sun.GetComponent<SunHandler>().hasBase = true;
		sun.GetComponent<SunHandler>().HangerSlots += 2;
		GameManager.subMoney(2000);
		GameManager.startingPlanetSelected = true;
		sun.GetComponent<SunHandler>().Default();
		Disable();
		Enable();
	}

	public void BuyHanger()
	{
		GameManager.subMoney(500);
		sun.GetComponent<SunHandler>().HangerSlots += 1;

	}

	public void buyShip()
	{
		if(sun.GetComponent<SunHandler>().HangerSlots > 0)
		{
			GameManager.subMoney(500);
			sun.GetComponent<SunHandler>().Ships += 1;
			sun.GetComponent<SunHandler>().HangerSlots -= 1;
			GameManager.totalNumberOfShips += 1;
		}
	}
	private int IntendedCargo = 0;
	private int IntendedPeople = 0;

	public void addAPerson()
	{
		if(IntendedCargo + IntendedPeople < 50 && IntendedPeople < sun.GetComponent<SunHandler>().MoveableHumans)
		{
			IntendedPeople += 1;
		}
	}
	public void addACargo()
	{
		if(IntendedCargo + IntendedPeople < 50 && IntendedCargo < sun.GetComponent<SunHandler>().MoveableCargo)
		{
			IntendedCargo += 1;
		}
	}

	public void subAPerson()
	{
		if(IntendedPeople > 0)
		{
			IntendedPeople -= 1;
		}
	}

	public void subACargo()
	{
		if(IntendedCargo > 0)
		{
			IntendedCargo -= 1;
		}

	}

	public void setShipTarget()
	{
		GameManager.selectionMode = true;
		Disable();
	}


	public void SendShip()
	{
		SunHandler SH = sun.GetComponent<SunHandler>();
		if(SH.Ships <= 0 || targetSun == null){return;}
		SH.Ships -= 1;
		SH.HangerSlots += 1;
		Vector3 start = new Vector3(sun.transform.position.x + 2, sun.transform.position.y + 1, sun.transform.position.z);
		GameObject ship = (GameObject)Instantiate(ShipPrefab, start, Quaternion.identity);
		ShipController cont = ship.GetComponent<ShipController>();
		cont.setCargo(IntendedCargo);
		cont.setPeople(IntendedPeople);

		float xPos = targetSun.transform.position.x;
		float yPos = targetSun.transform.position.y;
		cont.setTarget(xPos, yPos);

		SH.MoveableCargo -= IntendedCargo;
		SH.MoveableHumans -= IntendedPeople;

		IntendedCargo = 0;
		IntendedPeople = 0;

		HandleBack();
		HandleBack();
	
		cont.ready = true;
	}

	//getters

	public int getIntendedCargo(){return IntendedCargo;}
	public int getIntendedPeople(){return IntendedPeople;}
}
