using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour {

	public GameObject options;

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			ShowOptions();
		}
	}

	void OnMouseDown()
	{
		ShowOptions ();
	}

	public void ShowOptions()
	{
		if (!options.activeInHierarchy)
		{
			options.SetActive (true);
		}

		else
		{
			options.SetActive (false);
		}
	}
}
