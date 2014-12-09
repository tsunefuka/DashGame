using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Animator))]
public class ThreeLineController : MonoBehaviour
{
	private const float INTERVAL_INPUT = 10.0f;

	public int numLine = 3;
	public int flipWidth = 1;

	protected Animator animator;
	protected int nowLine = 2;

	void Start ()
	{
		this.animator = GetComponent<Animator> ();
	}
	
	void Update ()
	{
		this.Move ();
	}

	private void Move()
	{
		if (Input.GetButtonDown("right") && this.nowLine > 1) 
		{
			this.nowLine--;
			this.transform.position += Vector3.forward * (-1) * this.flipWidth;
		} 
		else if (Input.GetButtonDown("left") && this.nowLine < this.numLine) 
		{
			this.nowLine++;
			this.transform.position += Vector3.forward * this.flipWidth;
		}
	}
}
