using UnityEngine;
using System.Collections;

public class cubeLine : MonoBehaviour {
	public GameObject cube;
	public static GameObject[] allCubes=new GameObject[16];
	// Use this for initialization
	void Start () {
		int loc=-15;
		for (int i = 0; i < 16; i++) 
		{
			allCubes[i]=(GameObject) Instantiate (cube, new Vector3 (loc, 0, 0), Quaternion.identity);
			loc += 2;

		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
