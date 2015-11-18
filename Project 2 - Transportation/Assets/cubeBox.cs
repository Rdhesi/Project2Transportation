using UnityEngine;
using System.Collections;

public class cubeBox : MonoBehaviour {
	public GameObject cube;
	public static GameObject[,] allCubes=new GameObject[4,16];
	// Use this for initialization
	void Start () {
		int loc=-15;
		int loc2=-2;
		for (int x = 0; x < 4; x++) 
		{
			for (int i = 0; i < 16; i++) 
			{
				allCubes[x,i]=(GameObject) Instantiate (cube, new Vector3 (loc, loc2, 0), Quaternion.identity);
				loc += 2;

			}
			loc2+=2;
			loc=-15;
		}
		allCubes[3,0].GetComponent<Renderer>().material.color = Color.red;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
