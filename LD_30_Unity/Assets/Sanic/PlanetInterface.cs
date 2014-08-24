using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class PlanetInterface : MonoBehaviour {

	public GameObject sun;

	private Text PlanetName;


	//Back button
	private Image Back_ButtonImage;

	private Button Back_Button;

	private Text Back_ButtonText;

	//Found Base button
	private Image Found_ButtomImage;

	private Button Found_Button;

	private Text Found_ButtonText;

	public void Start()
	{
		PlanetName = transform.FindChild("Planet_Name").GetComponent<Text>();

		// Back Button
		Back_ButtonImage = transform.FindChild("Back_Button").GetComponent<Image>();

		Back_Button = transform.FindChild("Back_Button").GetComponent<Button>();

		Back_ButtonText = transform.FindChild("Back_Button/Text").GetComponent<Text>();


		//Found Button
		Found_ButtomImage = transform.FindChild("Found_Button").GetComponent<Image>();

		Found_Button = transform.FindChild("Found_Button").GetComponent<Button>();

		Found_ButtonText = transform.FindChild("Found_Button/Text").GetComponent<Text>();

		Disable();
	}



	void Update () 
	{
		if(sun != null)
		{
			PlanetName.text = sun.GetComponent<SunHandler>().name;
		}

	}


	public void Disable()
	{
		transform.GetComponent<Image>().enabled = false;
		PlanetName.enabled = false;

		Back_Button.enabled = false;
		Back_ButtonImage.enabled = false;
		Back_ButtonText.enabled = false;

		Found_ButtomImage.enabled = false;
		Found_Button.enabled = false;
		Found_ButtonText.enabled = false;


		sun = null;
	}

	public void Enable()
	{
		transform.GetComponent<Image>().enabled = true;

		PlanetName.enabled = true;

		Back_Button.enabled = true;
		Back_ButtonImage.enabled = true;
		Back_ButtonText.enabled = true;


		if(!sun.GetComponent<SunHandler>().hasBase)
		{
			Found_ButtomImage.enabled = true;
			Found_Button.enabled = true;
			Found_ButtonText.enabled = true;

		}
	
	}
}
