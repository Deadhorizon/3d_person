using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenDevice : MonoBehaviour
{
	[SerializeField]
	Vector3 dPos;
	private bool _open;
	public float smoothing = 0.1f;
	void Operate()
	{
		if (_open)
		{
			Vector3 pos = transform.position - dPos;
			transform.position = pos;
		}
		else {
			Vector3 pos = transform.position + dPos;
			transform.position = Vector3.Lerp(transform.position, pos, smoothing * Time.deltaTime);
		}
		_open = !_open;
	}
	public void Activate()
	{
		if (!_open)
		{
			Vector3 pos = transform.position + dPos;
			transform.position = pos;
			_open = true;
		}
	}
	public void Deactivate()
	{
		if (_open)
		{
			Vector3 pos = transform.position - dPos;
			transform.position = pos;
			_open = false;
		}
	}
}
