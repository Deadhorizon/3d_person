using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
	public float sensHor = 9.0f;
	public float sensVert = 9.0f;
	public float maxVert = 45.0f;
	public float minVert = -45.0f;
	public enum Mouse_Cont
	{
		MouseX_Y=0,
		MouseX=1,
		MouseY=2,

	}
	private float _rotationX;
	public Mouse_Cont axes = Mouse_Cont.MouseX_Y;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (axes == Mouse_Cont.MouseX)
		{
			transform.Rotate(0, Input.GetAxis("Mouse X") * sensHor, 0);
		}
		else if (axes == Mouse_Cont.MouseY)
		{
			_rotationX -= Input.GetAxis("Mouse Y") * sensVert;
			_rotationX = Mathf.Clamp(_rotationX, minVert, maxVert);
			 float _rotationY = transform.localEulerAngles.y;
			transform.localEulerAngles = new Vector3(_rotationX, _rotationY,0);
		}
		else
		{
			_rotationX -= Input.GetAxis("Mouse Y") * sensVert;
			_rotationX = Mathf.Clamp(_rotationX, minVert, maxVert);

			float delta = Input.GetAxis("Mouse X") * sensHor;
			float rotationY = transform.localEulerAngles.y + delta;
			transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
		}
    }
}
