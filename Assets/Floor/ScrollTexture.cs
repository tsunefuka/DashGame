using UnityEngine;
using System.Collections;

public class ScrollTexture : MonoBehaviour
{
	public float speed = 0.1f;

	void Update ()
	{
		float y = Mathf.Repeat (Time.time * speed, 1);
		Vector2 offset = new Vector2 (0, -1 * y);
		renderer.sharedMaterial.SetTextureOffset ("_MainTex", offset);
	}
}
