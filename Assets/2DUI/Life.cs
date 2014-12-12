﻿using UnityEngine;
using System.Collections;

public class Life : MonoBehaviour
{
	private Manager manager;
	private UILabel myLabel;

	void Start ()
	{
		this.manager = (GameObject.Find("Manager")).GetComponent<Manager> ();
		this.myLabel = this.gameObject.GetComponent<UILabel> ();
	}
	
	void Update ()
	{
		this.myLabel.text = this.manager.getLife ().ToString ();
	}
}
