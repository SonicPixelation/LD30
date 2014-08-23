using UnityEngine;
using System.Collections;

// Writtten by Sanic

public class Camera_Controller_Test : MonoBehaviour {
	
	
	private GameObject star0;
	
	private GameObject star1;
	
	private GameObject star2;
	
	private Camera cam;
	
	public float camMoveSpeed = 10;
	
	void Start () 
	{
		star0 = GameObject.Find ("Camera/Star_0").gameObject;
		
		star1 = GameObject.Find ("Camera/Star_1").gameObject;
		
		star2 = GameObject.Find("Camera/Star_2").gameObject;
		
		cam = transform.GetComponent<Camera>();
	}
	
	float xPos = 0;
	float yPos = 0;
	
	void Update () 
	{

		
		star0.renderer.material.mainTextureOffset = new Vector2(-xPos,-yPos);
		star1.renderer.material.mainTextureOffset = new Vector2(-xPos* .25f, -yPos * .25f);
		
		
		float xOff = Input.GetAxis("Horizontal") * camMoveSpeed * Time.deltaTime;
		float yOff = Input.GetAxis("Vertical") * camMoveSpeed * Time.deltaTime;
		
		
		transform.position += new Vector3(xOff,yOff,0);
		
		float scroll = Input.GetAxis("Mouse ScrollWheel");
		
		float size = 30 / (cam.orthographicSize / 5);
		
		star0.renderer.material.mainTextureScale = new Vector2(size,size);
		star1.renderer.material.mainTextureScale = new Vector2(size,size);
		star2.renderer.material.mainTextureScale = new Vector2(size,size);
	}
}
