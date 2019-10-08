using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableItem : MonoBehaviour
{
	[SerializeField]
	private string itemName;
	void OnTriggerEnter(Collider other)
	{
		Debug.Log("You have joined into a item zone" + itemName);
		Destroy(this.gameObject);
	}
}
