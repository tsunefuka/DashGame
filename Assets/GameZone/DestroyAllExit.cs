using UnityEngine;
using System.Collections;

public class DestroyAllExit : MonoBehaviour
{
	private void OnTriggerExit(Collider other)
	{
		Destroy (other.gameObject);
	}	
}
