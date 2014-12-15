using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour
{
	const int NUM_LINE = 3;
	const int FLIP_WIDTH = 1;

	public float gameSpeed = 1.0f;
	public GameObject character;

	protected float scrollSpeed = 1.0f;
	protected int earned_score = 0;
	protected int remain_life = 10;
	protected KeyboardInputController myKeyboardInputController;

	void Start ()
	{
		Time.timeScale = this.gameSpeed;
		this.myKeyboardInputController = new KeyboardInputController(this);
	}

	void Update ()
	{
		this.myKeyboardInputController.InputKeyboard ();
	}

	public ThreeLineController GetCharacter ()
	{
		return this.character.GetComponent<ThreeLineController> ();
	}

	public int getNumLine ()
	{
		return NUM_LINE;
	}

	public int getFlipWidth ()
	{
		return FLIP_WIDTH;
	}
	
	public float getScrollSpeed()
	{
		return this.scrollSpeed;
	}

	public void addScore(int score)
	{
		this.earned_score += score;
	}

	public float getScore()
	{
		return this.earned_score;
	}

	public void damage(int damage)
	{
		this.remain_life = Mathf.Max (this.remain_life - damage, 0);
	}

	public int getLife()
	{
		return this.remain_life;
	}
}
