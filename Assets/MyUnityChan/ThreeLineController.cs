using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Animator))]
public class ThreeLineController : MonoBehaviour
{
	private const float INTERVAL_INPUT = 10.0f;

	protected Animator animator;
	protected Manager manager;
	protected int nowLine = 2;

	void Start ()
	{
		this.animator = this.GetComponent<Animator> ();
		this.manager = (GameObject.Find("Manager")).GetComponent<Manager> ();
	}

	protected bool canMove ()
	{
		AnimatorStateInfo state = this.animator.GetCurrentAnimatorStateInfo (0);
		return state.IsName("RUN");
	}

	public void MoveRight ()
	{
		if (this.canMove () && this.nowLine > 1)
		{
			this.nowLine--;
			this.transform.position += Vector3.forward * (-1) * this.manager.getFlipWidth ();
		}
	}

	public void MoveLeft ()
	{
		if (this.canMove () && this.nowLine < this.manager.getNumLine ())
		{
			this.nowLine++;
			this.transform.position += Vector3.forward * this.manager.getFlipWidth ();
		}
	}

	public void Jump ()
	{
		if (this.canMove ())
		{
			this.animator.SetTrigger ("jump");
		}
	}

	void OnTriggerEnter (Collider collider)
	{
		string layerName = LayerMask.LayerToName(collider.gameObject.layer);
		switch (layerName)
		{
		case "Coin":
			this.CaptureCoin (collider.gameObject.GetComponent<Coin> ());
			Destroy (collider.gameObject);
			break;
		case "Wall":
			this.HitWall (collider.gameObject.GetComponent<Wall> ());
			break;
		}
	}

	protected void HitWall (Wall wall)
	{
		this.manager.damage (wall.getDamage ());
		this.animator.SetTrigger ("damage");
	}

	protected void CaptureCoin (Coin coin)
	{
		this.manager.addScore (coin.getScore ());
	}
}
