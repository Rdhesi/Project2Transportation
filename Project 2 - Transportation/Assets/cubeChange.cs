﻿using UnityEngine;
using System.Collections;

public class cubeChange : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	
	}
	
	// Update is called once per frame
	void OnMouseDown()
	{
		Debug.Log ("Clicked");
		foreach (GameObject oneCube in cubeLine.allCubes) 
		{
			oneCube.GetComponent<Renderer> ().material.color = Color.white;
		}
		GetComponent<Renderer>().material.color = Color.red;
	}
	void Update () {
	
	}
}
