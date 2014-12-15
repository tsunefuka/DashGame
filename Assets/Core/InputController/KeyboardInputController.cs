using UnityEngine;
using System.Collections;

public class KeyboardInputController
{
	protected Manager manager;
	
	public KeyboardInputController (Manager manager)
	{
		this.manager = manager;
	}
	
	public void InputKeyboard()
	{
		if (Input.GetButtonDown("right"))
		{
			this.manager.GetCharacter ().MoveRight ();
		} 
		else if (Input.GetButtonDown("left"))
		{
			this.manager.GetCharacter ().MoveLeft ();
		}
	}
	
}
