﻿using UnityEngine;
using System.Collections;

public class AdaptiveOpBtn : MonoBehaviour {

	public GameObject SettingsWindow;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnClick()
	{
		SettingsWindow.GetComponent<AdminSettingsManager>().Group_Clicked(3);
		
	}
}
