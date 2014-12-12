﻿using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Animator))]
public class ThreeLineController : MonoBehaviour
{
	private const float INTERVAL_INPUT = 10.0f;

	public int numLine = 3;
	public int flipWidth = 1;

	protected Animator animator;
	protected Manager manager;
	protected int nowLine = 2;

	void Start ()
	{
		this.animator = this.GetComponent<Animator> ();
		this.manager = (GameObject.Find("Manager")).GetComponent<Manager> ();
	}

	void Update ()
	{
		this.Move ();
	}

	private void Move()
	{
		AnimatorStateInfo state = this.animator.GetCurrentAnimatorStateInfo (0);
		if (state.IsName("RUN"))
	    {
			if (Input.GetButtonDown("right"))
			{
				this.MoveRight ();
			} 
			else if (Input.GetButtonDown("left"))
			{
				this.MoveLeft ();
			}
		}
	}

	public void MoveRight ()
	{
		if (this.nowLine > 1)
		{
			this.nowLine--;
			this.transform.position += Vector3.forward * (-1) * this.flipWidth;
		}
	}

	public void MoveLeft ()
	{
		if (this.nowLine < this.numLine)
		{
			this.nowLine++;
			this.transform.position += Vector3.forward * this.flipWidth;
		}
	}

	void OnTriggerEnter (Collider collider)
	{
		string layerName = LayerMask.LayerToName(collider.gameObject.layer);
		switch (layerName)
		{
		case "Coin":
			this.CaptureCoin (collider.gameObject.GetComponent<Coin> ());
			Destroy (collider.gameObject);
			break;
		case "Wall":
			this.HitWall (collider.gameObject.GetComponent<Wall> ());
			break;
		}
	}

	protected void HitWall (Wall wall)
	{
		this.manager.damage (wall.getDamage ());
		this.animator.SetTrigger ("damage");
	}

	protected void CaptureCoin (Coin coin)
	{
		this.manager.addScore (coin.getScore ());
	}
}
