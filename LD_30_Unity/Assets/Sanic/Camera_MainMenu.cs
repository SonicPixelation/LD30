using UnityEngine;
using System.Collections;

public class Camera_MainMenu : MonoBehaviour 
{
	private GameObject Star0;
	private GameObject Star1;

	public float scrollSpeed = .005f;

	public void Start()
	{
		Star0 = GameObject.Find ("Camera/Star_0").gameObject;
		Star1 = GameObject.Find ("Camera/Star_1").gameObject;
	}


	private float xPos = 0;
	private float yPos = 0;

	public void Update()
	{
		xPos += scrollSpeed;

		Debug.Log(Star0 + "," + Star1);

		Star0.renderer.material.mainTextureOffset = new Vector2(-xPos,-yPos);
		Star1.renderer.material.mainTextureOffset = new Vector2(-xPos * .25f, yPos * .25f);
	}
}
