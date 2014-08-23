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

	private bool[] linked;

	//
	void Start () 
	{
		GenerateNewStarPoint();


	}



	private int LastIndex = 0;
	void Update()
	{
		if(Input.GetKeyDown(KeyCode.G))
		{
			ClearWorld();
			GenerateNewStarPoint();
		}

		if(RenderGenDebugTrail)
		{

			for(int i = 0; i < suns.Count; i++)
			{
				int j = i + 1;

				if(j >= suns.Count){break;}

				Debug.DrawLine(suns[i], suns[j]);

			}
		}

		if(RenderPathDebugTrail)
		{
			for(int i = 0; i < suns.Count; i++)
			{
				float smallestDistance = Mathf.Infinity;
				int smallestDistanceIndex = -1;
			}
		}
	}


	private Vector2 LastPoint = new Vector2(0,0);

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
		linked = new bool[suns.Count];
	}


	public void CreateStar(Vector2 vec)
	{
		if(SunPrefab != null)
		{
			GameObject obj = (GameObject)Instantiate(SunPrefab,new Vector3(vec.x,vec.y, 2),Quaternion.identity);

			obj.transform.parent = transform;

			SpriteRenderer renderer = obj.GetComponentInChildren<SpriteRenderer>();
			renderer.color = new Vector4((float)random.NextDouble(),(float)random.NextDouble(),(float)random.NextDouble(),1);

		}
	}

	public void ClearWorld()
	{
		var children = new List<GameObject>();
		foreach(Transform child in transform) children.Add(child.gameObject); 

		children.ForEach(child=>Destroy(child));

		suns.Clear();
	}
}
