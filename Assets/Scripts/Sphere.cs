﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Remoting.Messaging;
using UnityEngine.AI;
using System.Threading;
using TMPro;

public class Sphere : MonoBehaviour {

	public GameObject options;

	// On right click the items menu object will become active and be displayed (toggle)
	// Dragging object with left click is controlled by MouseDrag script

	void OnMouseOver()
	{
		if (Input.GetMouseButtonDown(1))
		{
			ShowOptions ();
		}
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



	/*
	void OnCollisionEnter(Collision other)
	{
		do something (mixing results);
	}
	*/
}
