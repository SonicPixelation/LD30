using UnityEngine;
using System.Collections;

public class LDUtils {

	public static float getDistance2D(Vector2 vec0, Vector2 vec1)
	{
		float a = Mathf.Pow((vec0.x - vec1.x),2);
		float b = Mathf.Pow((vec0.y - vec1.y),2);

		float c = Mathf.Sqrt(a+b);

		return c;
	}
}
