using UnityEngine;
using System.Collections;

public class UIGroupManager : MonoBehaviour {


	public void Enable()
	{
		foreach(UIEnableControl c in transform.GetComponentsInChildren<UIEnableControl>())
		{
			c.Enable();
		}
	}


	public void Disable()
	{
		foreach(UIEnableControl c in transform.GetComponentsInChildren<UIEnableControl>())
		{
			c.Disable();
		}

	}
}
