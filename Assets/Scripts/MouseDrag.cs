using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag : MonoBehaviour {

	//float distance = 5.21f;

	void OnMouseDrag()
	{
			Vector3 mousePosition = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, transform.position.z);
			Vector3 objectPosition = Camera.main.ScreenToWorldPoint (mousePosition);

			transform.position = objectPosition;
	}
}
