using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIEnableControl : MonoBehaviour 
{

	public void Enable()
	{
		Image img = transform.GetComponent<Image>();
		if(img != null)
		{
			img.enabled = true;
		}

		Text t0 = transform.GetComponent<Text>();
		if(t0 != null)
		{
			t0.enabled = true;
		}

		Button b = transform.GetComponent<Button>();
		if(b != null)
		{
			b.enabled = true;


			Text t1 = transform.FindChild("Text").GetComponent<Text>();
			if(t1 != null)
			{
				t1.enabled = true;
			}
		}
	}


	public void Disable()
	{
		Image img = transform.GetComponent<Image>();
		if(img != null)
		{
			img.enabled = false;
		}
		
		Text t0 = transform.GetComponent<Text>();
		if(t0 != null)
		{
			t0.enabled = false;
		}
		
		Button b = transform.GetComponent<Button>();
		if(b != null)
		{
			b.enabled = false;
			
			

			if((transform.FindChild("Text").gameObject)!= null)
			{
				Text t1 = transform.FindChild("Text").GetComponent<Text>();
				if(t1 != null)
				{
					t1.enabled = false;
				}

			}
		}
	}
}
