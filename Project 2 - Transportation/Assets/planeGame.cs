using UnityEngine;
using System.Collections;

public class planeGame : MonoBehaviour {
	static bool isHigh=false;
	double startTime=0.0;
	double planeTurnTime=1.5;
	int cargo=0;
	int maxCargo=90;
	int score=0;
	//skySetup.allCubes [currX, currY] is the current box
	int currX;
	int currY;
	// Use this for initialization
	void Start () {
		startTime += planeTurnTime;	
		currX = skySetup.loc1x;	
		currY = skySetup.loc1y;
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
		/*else
			if(isHigh==true&&GetComponent<Renderer> ().material.color == Color.white)
		{
			foreach (GameObject oneCube in cubeBox.allCubes)
			{
				oneCube.GetComponent<Renderer> ().material.color = Color.white;
			}
			GetComponent<Renderer> ().material.color = Color.blue;
		}*/
	}
	void Update () {
		

			if (Time.time > startTime && currX == skySetup.loc1x && currY == skySetup.loc1y) {
			
				cargo += 10;
				if (cargo > maxCargo) {
					cargo = maxCargo;
				}
				print ("cargo: " + cargo);

				startTime += planeTurnTime;	

			} else if (Time.time > startTime && currX == skySetup.loc2x && currY == skySetup.loc2y) {
				score += cargo;
				cargo = 0;
				print ("score: " + score);
				print ("cargo: " + cargo);
				startTime += planeTurnTime;	

			}
		if (isHigh == true) {
			if (Input.GetKeyDown ("up")) {
				if (currX + 1 <= skySetup.loc1x) {
					currX++;
				}

			} else if (Input.GetKeyDown ("right")) {
				if (currY + 1 <= skySetup.loc2y) {
					currY++;
				}

			} else if (Input.GetKeyDown ("left")) {
				if (currY-1>=skySetup.loc1y) {
					currY--;
				}

			} else if (Input.GetKeyDown ("down")) {
				if (currX-1>=skySetup.loc2x) {
					currX--;
				}

			}
			if (Time.time > startTime) {
				foreach (GameObject oneCube in skySetup.allCubes) {
					oneCube.GetComponent<Renderer> ().material.color = Color.white;
				}
				skySetup.allCubes[0,15].GetComponent<Renderer>().material.color = Color.black;
				skySetup.allCubes [currX, currY].GetComponent<Renderer> ().material.color = Color.blue;


			}
		}
	}
}
