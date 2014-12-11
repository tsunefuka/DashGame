using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Animator))]
public class ThreeLineController : MonoBehaviour
{
	private const float INTERVAL_INPUT = 10.0f;

	public GameObject manager;
	public int numLine = 3;
	public int flipWidth = 1;

	protected Animator animator;
	protected Manager myManager;
	protected int nowLine = 2;

	void Start ()
	{
		this.animator = GetComponent<Animator> ();
		this.myManager = this.manager.GetComponent<Manager> ();
	}

	void Update ()
	{
		this.Move ();
	}

	private void Move()
	{
		if (Input.GetButtonDown("right"))
		{
			this.MoveRight ();
		} 
		else if (Input.GetButtonDown("left"))
		{
			this.MoveLeft ();
		}
	}

	public void MoveRight ()
	{
		if (this.nowLine > 1)
		{
			this.nowLine--;
			this.transform.position += Vector3.forward * (-1) * this.flipWidth;
		}
	}

	public void MoveLeft ()
	{
		if (this.nowLine < this.numLine)
		{
			this.nowLine++;
			this.transform.position += Vector3.forward * this.flipWidth;
		}
	}

	void OnTriggerEnter (Collider collider)
	{
		string layerName = LayerMask.LayerToName(collider.gameObject.layer);
		switch (layerName)
		{
		case "Coin":
			ScrollItem scrollItem = collider.gameObject.GetComponent<ScrollItem> ();
			this.myManager.addScore (scrollItem.getScore ());
			Destroy (collider.gameObject);
			break;
		case "Wall":
			ScrollWall scrollWall = collider.gameObject.GetComponent<ScrollWall> ();
			this.myManager.damage (scrollWall.getDamage ());
			break;
		}
	}
}
