using UnityEngine;
using System.Collections;

public class ShipController : MonoBehaviour {
	
	private int Cargo;
	private int Persons;

	private float XTarget;
	private float YTarget;

	private float speed = 0.1f;

	public bool ready = false;

	public void Start()
	{
		speed = 2;
	}


	public void Update()
	{
		if(ready)
		{

			Vector3 vel = Vector3.zero;

			if((transform.position.x - XTarget) > 0)
			{
				vel.x = -speed * Time.deltaTime;
			}
			else
			if((transform.position.x - XTarget) < 0)
			{
				vel.x = speed * Time.deltaTime;
			}

			if((transform.position.y - YTarget) > 0)
			{
				vel.y = -speed * Time.deltaTime;
			}
			else
				if((transform.position.y - YTarget) < 0)
			{
				vel.y = speed * Time.deltaTime;
			}

			transform.position += vel;
		}
	}

	//setters
	public void setCargo(int num){Cargo = num;}
	public void setPeople(int num){Persons = num;}

	public void setTarget(float x, float y)
	{
		this.XTarget = x;
		this.YTarget = y;
	}


	//getters
	public int getCargo(){return Cargo;}
	public int getPeople(){return Persons;}
	public float getXTarget(){return XTarget;}
	public float getYTarget(){return YTarget;}
}
