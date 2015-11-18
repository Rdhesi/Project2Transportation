using UnityEngine;
using System.Collections;

public class CubeBehavior : MonoBehaviour {
	public int x, y;
	// Use this for initialization
	void Start () {
	
	}
	void OnMouseDown()
	{
		
		GameController.ProcessClickedCube (this.gameObject,x,y);
	}
	// Update is called once per frame
	void Update () {

	
	}
}
