using UnityEngine;
using System.Collections;

public class ScrollItem : ScrollObject
{
	public int score = 1;

	void OnTriggerEnter (Collider collider)
	{
		this.manager.GetComponent<Manager> ().addScore (this.score);
		Destroy (this.gameObject);
	}
}
