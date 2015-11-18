using UnityEngine;
using System.Collections;

public class skySetup : MonoBehaviour {
	public GameObject cube;
	public static int loc1x, loc2x, loc1y, loc2y;

	public static GameObject[,] allCubes=new GameObject[9,16];
	// Use this for initialization
	void Start () {
		int loc=-15;
		int loc2=-2;
		for (int x = 0; x < 9; x++) 
		{
			for (int i = 0; i < 16; i++) 
			{
				allCubes[x,i]=(GameObject) Instantiate (cube, new Vector3 (loc, loc2, 0), Quaternion.identity);
				loc += 2;

			}
			loc2+=2;
			loc=-15;
		}
		allCubes[8,0].GetComponent<Renderer>().material.color = Color.red;
		//these are the variables for the location of the starting point of the plane. The x and y wound up reversed but this wasn't realized until it was too late.
		//so it's for the allCubes[x,y]
		loc1x = 8;
		loc1y=0;
		allCubes[0,15].GetComponent<Renderer>().material.color = Color.black;
		//these are the variables for the location of the drop point of the plane
		loc2x = 0;
		loc2y = 15;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
