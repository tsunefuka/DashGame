using UnityEngine;
using System.Collections;

public class Rolling : MonoBehaviour
{
	public int speed = 5;

	void Update () 
	{
		this.transform.Rotate (0, 0, this.speed);
	}
}
