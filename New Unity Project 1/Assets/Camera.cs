using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {
	private float z = -61f;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		Debug.Log (GameObject.FindGameObjectsWithTag ("satilite") [0].transform.position);
		float x = GameObject.FindGameObjectsWithTag ("satilite") [0].transform.position.x;
		float y = GameObject.FindGameObjectsWithTag ("satilite") [0].transform.position.y;
		z = z + Input.GetAxis ("Mouse ScrollWheel") * 10f;
		transform.position = new Vector3 (x,y,z);
	}
}
