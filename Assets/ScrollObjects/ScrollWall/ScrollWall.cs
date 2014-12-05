using UnityEngine;
using System.Collections;

public class ScrollWall : ScrollObject
{
	public int damage = 1;

	void OnTriggerEnter (Collider collider)
	{
		this.manager.GetComponent<Manager> ().damage (this.damage);
		Debug.Log("hit wall");
	}
}
