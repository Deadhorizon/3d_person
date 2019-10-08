using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour,IGameManager
{
	public ManagerStatus status { get; private set; }

	// Update is called once per frame
	public void StartUp()
    {
		Debug.Log("Inventory managment starting");
		status = ManagerStatus.Started;
    }
}
