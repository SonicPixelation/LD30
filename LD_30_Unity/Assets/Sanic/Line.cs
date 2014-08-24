using UnityEngine;
using System.Collections;

public class Line  {
	
	public Vector2 a;
	public Vector2 b;


	public Line(Vector2 a, Vector2 b)
	{
		this.a = a;
		this.b = b;
	}


	public Line(float xa, float ya, float xb, float yb)
	{
		this.a = new Vector2(xa,ya);
		this.b = new Vector2(xb,yb);
	}
}
