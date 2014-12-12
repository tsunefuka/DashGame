using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour
{
	public float gameSpeed = 1.0f;

	protected float scrollSpeed = 1.0f;
	protected int earned_score = 0;
	protected int remain_life = 10;

	void Start ()
	{
		Time.timeScale = this.gameSpeed;
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
