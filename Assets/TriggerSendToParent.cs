using UnityEngine;
using System.Collections;

public class TriggerSendToParent : MonoBehaviour
{
	protected GameObject parent;

	void Start ()
	{
		this.parent = this.gameObject.transform.parent.gameObject;
	
	}

	void OnTriggerEnter (Collider collider)
	{
		this.parent.SendMessage ("OnTriggerEnter", collider);
	}
}
