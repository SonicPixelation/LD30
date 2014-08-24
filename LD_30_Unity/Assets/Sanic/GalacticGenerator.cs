using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;


//Written by Sanic
//the script that generates 
//the galaxy
public class GalacticGenerator : MonoBehaviour {



	// public var
	public int WorldWidth = 1000;

	public int WorldHeight = 1000;

	public int NumberOfStars = 30;

	public float MinStarDistance = 20;

	public float MaxStarDistance = 20;

	public bool RenderGenDebugTrail = false;

	public bool RenderPathDebugTrail = false;

	public GameObject SunPrefab;


	//private vars
	private System.Random random = new System.Random();

	private List<Vector2> suns = new List<Vector2>();


	//
	void Start () 
	{
		GenerateNewStarPoint();
	}




	void Update()
	{
		if(RenderGenDebugTrail)
		{

			for(int i = 0; i < suns.Count; i++)
			{
				int j = i + 1;

				if(j >= suns.Count){break;}

				Debug.DrawLine(suns[i], suns[j]);

			}
		}
	}
	
	

	private void GenerateNewStarPoint()
	{
		for(int i = 0; i < NumberOfStars; i++)
		{
			bool canContinue = true;
			float xt = random.Next(-WorldWidth / 2,WorldWidth / 2);
			float yt = random.Next(-WorldHeight / 2,WorldHeight / 2);

			Vector2 core = new Vector2(xt,yt);

			foreach(Vector2 vec in suns)
			{
				if(LDUtils.getDistance2D(core,vec) < MinStarDistance || LDUtils.getDistance2D(core,vec) > MaxStarDistance)
				{

					canContinue = false;
					Debug.Log ("Bad World");
					i--;
					break;
				}

			}

			if(canContinue)
			{
				suns.Add(core);
				CreateStar(core);


			}
			
		}

	}


	public void CreateStar(Vector2 vec)
	{
		if(SunPrefab != null)
		{
			GameObject obj = (GameObject)Instantiate(SunPrefab,new Vector3(vec.x,vec.y, 2),Quaternion.identity);

			obj.transform.parent = transform.FindChild("Canvas").transform;

			Vector4 color = LDUtils.planetColors[random.Next(0,LDUtils.planetColors.Count)];

			for(int i = 0; i < obj.transform.childCount; i++)
			{
				GameObject gobject = obj.transform.GetChild(i).gameObject;
				SpriteRenderer renderer = obj.transform.GetChild(i).gameObject.GetComponent<SpriteRenderer>();

				SunHandler handler = obj.transform.GetComponent<SunHandler>();

				handler.name = LDUtils.planetNames[random.Next(0,LDUtils.planetNames.Count)];

				if(renderer == null || gobject.name == "Selector")
				{
					CanvasRenderer cRenderer = gobject.GetComponent<CanvasRenderer>();
					if(cRenderer != null)
					{
						cRenderer.SetColor(color);
					}
				}
				else
				{
					renderer.color = color;
				}

			}
		}
	}

	public void ClearWorlds()
	{
		var children = new List<GameObject>();
		foreach(Transform child in transform) children.Add(child.gameObject); 

		children.ForEach(child=>Destroy(child));

		suns.Clear();
	}
}
