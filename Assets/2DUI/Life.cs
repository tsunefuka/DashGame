using UnityEngine;
using System.Collections;

public class Life : MonoBehaviour
{
	public GameObject manager;

	private Manager myManager;
	private UILabel myLabel;

	void Start ()
	{
		this.myManager = this.manager.GetComponent<Manager> ();
		this.myLabel = this.gameObject.GetComponent<UILabel> ();
	}
	
	void Update ()
	{
		this.myLabel.text = this.myManager.getLife ().ToString ();
	}
}
