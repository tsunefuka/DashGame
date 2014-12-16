using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour
{
	const int GAME_STATUS_TITLE = 0;
	const int GAME_STATUS_PLAY = 1;
	const int GAME_STATUS_END = -1;

	const int NUM_LINE = 3;
	const int FLIP_WIDTH = 1;

	public float gameSpeed = 1.0f;
	public GameObject character;

	public GameObject titleContainer;
	public GameObject playContainer;

	protected int gameStatus;
	protected float scrollSpeed = 1.0f;
	protected int earned_score = 0;
	protected int remain_life = 10;
	protected KeyboardInputController myKeyboardInputController;

	void Start ()
	{
		this.gameStatus = GAME_STATUS_TITLE;
		Time.timeScale = this.gameSpeed;
		this.myKeyboardInputController = new KeyboardInputController(this);
	}

	void Update ()
	{
		switch (this.gameStatus)
		{
		case GAME_STATUS_TITLE:
			break;
		case GAME_STATUS_PLAY:
			this.myKeyboardInputController.InputKeyboard ();
			break;
		case GAME_STATUS_END:
			break;
		}
	}

	public void GameStart ()
	{
		this.titleContainer.SetActive (false);
		this.playContainer.SetActive (true);
		this.gameStatus = GAME_STATUS_PLAY;
	}

	public bool isGameStatusTitle ()
	{
		return this.gameStatus == GAME_STATUS_TITLE;
	}
	public bool isGameStatusPlay ()
	{
		return this.gameStatus == GAME_STATUS_PLAY;
	}
	public bool isGameStatusEnd ()
	{
		return this.gameStatus == GAME_STATUS_END;
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
