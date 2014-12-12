using UnityEngine;
using System.Collections;

public class ScrollTexture : MonoBehaviour
{
	protected Manager manager;

	void Start ()
	{
		this.manager = (GameObject.Find("Manager")).GetComponent<Manager> ();
	}

	void Update ()
	{
		float speed = this.manager.GetComponent<Manager> ().getSpeed ();
		float y = Mathf.Repeat (Time.time * speed, 1);
		Vector2 offset = new Vector2 (0, -1 * y);
		renderer.sharedMaterial.SetTextureOffset ("_MainTex", offset);
	}
}
