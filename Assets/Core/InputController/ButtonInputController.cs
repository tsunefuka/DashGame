using UnityEngine;
using System.Collections;

public class ButtonInputController : MonoBehaviour
{
	protected Manager manager;

	void Start ()
	{
		this.manager = (GameObject.Find ("Manager") as GameObject).GetComponent<Manager> ();
	}

	public void GameStart ()
	{
		this.manager.GameStart ();
	}

	public void MoveRight ()
	{
		this.manager.GetCharacter ().MoveRight ();
	}

	public void MoveLeft ()
	{
		this.manager.GetCharacter ().MoveLeft ();
	}

	public void Jump ()
	{
		this.manager.GetCharacter ().Jump ();
	}

	public void GameBackTitle ()
	{
		this.manager.GameBackTitle ();
	}
}
