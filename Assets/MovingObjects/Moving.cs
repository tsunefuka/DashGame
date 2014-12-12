using UnityEngine;
using System.Collections;

// プレイヤーに向かってくる障害物・アイテムの親クラス
public class Moving : MonoBehaviour
{
	public GameObject manager;

	protected Vector3 intial_position;
	protected Manager myManager;

	void Start ()
	{
		this.intial_position = this.transform.position;
		this.myManager = this.manager.GetComponent<Manager> ();
	}

	void Update ()
	{
		// 向かってくる処理
		float speed = 2.0f * this.myManager.getSpeed ();
		this.transform.position = this.intial_position + this.transform.forward * speed * Time.time;
	}
}
