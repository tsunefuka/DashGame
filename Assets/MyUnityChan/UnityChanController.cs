using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Animator))]
public class UnityChanController : MonoBehaviour
{
	private const float SPEED = 1.0f;

	private Animator animator;
	private int speedId;
	
	void Start()
	{
		this.animator = GetComponent<Animator> ();
		this.speedId = Animator.StringToHash ("speed");
	}

	void Update()
	{
		this.Move ();
	}

	void Move()
	{
		float speed = 0.0f;
		if (Input.GetKey(KeyCode.UpArrow)) 
		{
			speed = 1.0f * SPEED;
		} 
		else 
		{
			speed = 0.0f;
		}
		this.animator.SetFloat (this.speedId, speed);
		this.transform.position += this.transform.forward * speed;

		if (Input.GetKey(KeyCode.RightArrow)) 
		{
			this.transform.Rotate (0, 10, 0);
		} 
		else if (Input.GetKey(KeyCode.LeftArrow)) 
		{
			this.transform.Rotate (0, -10, 0);
		}
	}
}
