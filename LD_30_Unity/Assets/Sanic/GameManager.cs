using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static bool startingPlanetSelected = false;

	public int startingMoney = 10000;


	public static int money;


	public void Awake()
	{
		LDUtils.LoadColors();
		LDUtils.LoadPlanetNames();
		money = startingMoney;
	}
}
