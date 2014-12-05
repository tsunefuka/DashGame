using UnityEngine;
using System.Collections;

// プレイヤーに向かってくる障害物・アイテムの親クラス
public class ScrollObject : MonoBehaviour
{
	public GameObject manager;

	protected Vector3 intial_position;

	void Start ()
	{
		this.intial_position = this.transform.position;
	}

	void Update ()
	{
		// 向かってくる処理
		float speed = 2.0f * this.manager.GetComponent<Manager> ().getSpeed ();
		this.transform.position = this.intial_position + this.transform.forward * speed * Time.time;
	}

	void OnTriggerEnter (Collider collider)
	{
				Debug.Log ("hit object");
	}
}
