using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
	// public float mousesensitivity = 100f;
	// public Transform playerbody;
	// float xrotation = 0f;

	// // Start is called before the first frame update
	// void Start()
	// {
	//     Cursor.lockState = CursorLockMode.Locked;
	// }
	//public float mouseX;
	// // Update is called once per frame
	// void Update()
	// {
	//      mouseX = Input.GetAxis("Mouse X") * mousesensitivity * Time.deltaTime;
	//     float mouseY = Input.GetAxis("Mouse Y") * mousesensitivity * Time.deltaTime;

	//     xrotation -= mouseY;
	//     xrotation = Mathf.Clamp(xrotation, -90f, 90f);

	//     transform.localRotation = Quaternion.Euler(xrotation, mouseX, 0f);
	//     playerbody.Rotate(Vector3.up * mouseX);
	// }
	Vector2 rotation = Vector2.zero;
	public float speed = 3;

	void Update()
	{
		
		rotation.y += Input.GetAxis("Mouse X");
		rotation.x -= Input.GetAxis("Mouse Y");

		
		rotation.x = Mathf.Clamp(rotation.x, -20f, 20f);

		
		transform.eulerAngles = new Vector3(rotation.x, rotation.y, 0) * speed;
		
	}
}
