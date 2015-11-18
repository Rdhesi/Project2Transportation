using UnityEngine;
using System.Collections;

public class newCubeChange : MonoBehaviour {
	static bool isHigh=false;
	// Use this for initialization
	void Start () {
		
	
	}
	
	// Update is called once per frame
	void OnMouseDown()
	{
		if(GetComponent<Renderer> ().material.color == Color.red||GetComponent<Renderer> ().material.color == Color.blue)
		{
			print("clicked");
			if(isHigh==false)
			{
				GetComponent<Renderer> ().material.color = Color.blue;
				isHigh=true;
			}
			else if(isHigh==true)
			{
				GetComponent<Renderer> ().material.color = Color.red;
				isHigh=false;
			}
		}
		else
			if(isHigh==true&&GetComponent<Renderer> ().material.color == Color.white)
		{
			foreach (GameObject oneCube in cubeBox.allCubes)
			{
				oneCube.GetComponent<Renderer> ().material.color = Color.white;
			}
			GetComponent<Renderer> ().material.color = Color.red;
				isHigh=false;
		}
	}
	void Update () {
	
	}
}
