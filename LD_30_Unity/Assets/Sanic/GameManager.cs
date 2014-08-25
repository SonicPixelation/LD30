using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static bool startingPlanetSelected = false;

	public int startingMoney = 10000;

	public static bool selectionMode;
	
	public static int totalNumberOfShips = 0;

	public static int money;

	public static bool Broke = false;

	public static int MoneyMade = 0;

	private bool menuEnabled = false;

	private PlanetInterface PI;

	private GameObject FailScreen;

	private GameObject EscapeMenu;

	public void Awake()
	{
		LDUtils.LoadColors();
		LDUtils.LoadPlanetNames();
		money = startingMoney;
		PI = GameObject.Find ("Main Canvas/Center").GetComponent<PlanetInterface>();
		FailScreen = GameObject.Find("Main Canvas/FailState");
		EscapeMenu = GameObject.Find("Main Canvas/EscapeMenu");
		FailScreen.GetComponent<UIGroupManager>().Disable();
		EscapeMenu.GetComponent<UIGroupManager>().Disable();
		Broke = false;
	}


	public void Update()
	{
		if(Broke)
		{
			PI.HandleBack();
			PI.HandleBack();
			FailScreen.GetComponent<UIGroupManager>().Enable();
		}


		if(Input.GetKeyDown(KeyCode.Escape))
		{
			if(selectionMode)
			{
				selectionMode = false;
				PI.manageShips();

			}
			else
			if(!menuEnabled && !selectionMode)
			{
				PI.HandleBack();
				PI.Disable();
				EscapeMenu.GetComponent<UIGroupManager>().Enable();
				menuEnabled = true;
			}
			else
			if(menuEnabled && !selectionMode)
			{
				EscapeMenu.GetComponent<UIGroupManager>().Disable();
				menuEnabled = false;
			}
		}
	}

	public void QuitGame()
	{
		Application.Quit();
	}

	public void RestartGame()
	{
		Application.LoadLevel(0);
	}


	public static void subMoney(int m)
	{
		money -= m;
		if(money < 0)
		{
			Broke = true;
		}
	
	}

	public static void addMoney(int amount)
	{
		money += amount;
		MoneyMade += amount;
	}
}
