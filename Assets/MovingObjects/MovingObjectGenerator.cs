﻿using UnityEngine;
using System.Collections;

public class MovingObjectGenerator : MonoBehaviour 
{
	public GameObject[] generateObjects;
	public float spanSecond = 3.0f;

	protected Manager manager;
	protected Vector3 initPosition;
	protected Quaternion initRotation;

	void Start ()
	{
		this.manager = (GameObject.Find("Manager")).GetComponent<Manager> ();
		this.initPosition = this.transform.position;
		this.initRotation = this.transform.rotation;
		StartCoroutine ("Generate");
	}

	protected IEnumerator Generate ()
	{
		while (true)
		{
			if (this.manager.isGameStatusPlay ())
			{
				this.GenerateObject ();
			}
			yield return new WaitForSeconds (this.spanSecond);
		}
	}

	protected void GenerateObject ()
	{
		int lineIndex = Random.Range ((int)this.manager.getNumLine ()/2*(-1), (int)this.manager.getNumLine ()/2 + 1);
		Vector3 position = new Vector3 (this.initPosition.x, this.initPosition.y, this.initPosition.z + lineIndex);

		int index = Random.Range (0, this.generateObjects.Length);
		GameObject generatedObject = Instantiate (this.generateObjects[index], position, this.initRotation) as GameObject;
		Moving movingObject = generatedObject.GetComponent<Moving> ();
		movingObject.SetSpawnedSecond (Time.time);
	}
}
