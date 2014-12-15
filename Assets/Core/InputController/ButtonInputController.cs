using UnityEngine;
using System.Collections;

public class ButtonInputController : MonoBehaviour
{
	protected Manager manager;

	void Start ()
	{
		this.manager = (GameObject.Find ("Manager") as GameObject).GetComponent<Manager> ();
	}

	public void MoveRight ()
	{
		this.manager.GetCharacter ().MoveRight ();
	}

	public void MoveLeft ()
	{
		this.manager.GetCharacter ().MoveLeft ();
	}
}
