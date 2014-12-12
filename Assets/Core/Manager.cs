using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour
{
	public float speed = 0.5f;

	protected int earned_score = 0;

	protected int remain_life = 10;
	
	public float getSpeed()
	{
		return this.speed;
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
