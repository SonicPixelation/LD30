using UnityEngine;
using System.Collections;

public class Camera_Controller : MonoBehaviour {


	private GameObject star0;

	private GameObject star1;

	public float camMoveSpeed = 10;

	void Start () 
	{
		star0 = GameObject.Find ("Camera/Star_0").gameObject;
		star1 = GameObject.Find ("Camera/Star_1").gameObject;
	}
	
	float xPos = 0;
	float yPos = 0;

	void Update () 
	{
		xPos += Input.GetAxis("Horizontal") * Time.deltaTime * .1f;
		yPos += Input.GetAxis("Vertical") * Time.deltaTime * .1f;

		xPos = xPos % 1;
		yPos = yPos % 1;

		star0.renderer.material.mainTextureOffset = new Vector2(-xPos,-yPos);
		star1.renderer.material.mainTextureOffset = new Vector2(-xPos* .25f, -yPos * .25f);


		float xOff = Input.GetAxis("Horizontal") * camMoveSpeed * Time.deltaTime;
		float yOff = Input.GetAxis("Vertical") * camMoveSpeed * Time.deltaTime;


		transform.position += new Vector3(xOff,yOff,0);
	}
}
