﻿using UnityEngine;
using System.Collections;

public class BothEarCheckBox : MonoBehaviour {

	public GameObject EarSelectWindow;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnActivate( bool status)
	{
		EarSelectWindow.GetComponent<EarSelectionManager>().updateEarSelect(status,2);
	}
}
