using UnityEngine;
using System.Collections;

public class PublicVelocityData : MonoBehaviour {


	public float x = 0, y = 0 , z = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(x,y,z);
	}
}
