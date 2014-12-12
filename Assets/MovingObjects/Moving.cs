using UnityEngine;
using System.Collections;

// プレイヤーに向かってくる障害物・アイテムの親クラス
public class Moving : MonoBehaviour
{
	protected Manager manager;
	protected Vector3 intial_position;
	protected float spawnedSecond = 0.0f;

	void Start ()
	{
		this.manager = (GameObject.Find("Manager")).GetComponent<Manager> ();
		this.intial_position = this.transform.position;
	}

	void Update ()
	{
		// 向かってくる処理
		float speed = 2.0f * this.manager.getSpeed ();
		this.transform.position = this.intial_position + this.transform.forward * speed * this.getTimeFromSpawned ();
	}

	public void SetSpawnedSecond (float second)
	{
		this.spawnedSecond = second;
	}

	protected float getTimeFromSpawned ()
	{
		return Time.time - this.spawnedSecond;
	}
}
