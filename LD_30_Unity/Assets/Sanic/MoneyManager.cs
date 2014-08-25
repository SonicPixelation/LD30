using UnityEngine;
using System;
using System.Collections;
using UnityEngine.UI;

public class MoneyManager : MonoBehaviour {


	public void Update()
	{
		transform.GetComponent<Text>().text = GameManager.money + " :Credits";
	}
}
