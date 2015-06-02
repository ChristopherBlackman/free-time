using UnityEngine;
using System.Collections;

public class Circle : MonoBehaviour {

	private float i = 0f;

	// Use this for initialization
	void Start () {
	
	}
	// Update is called once per frame
	void Update () {
		float posOfOrbit_x=0f, posOfOrbit_y= 0f,posOfOrbit_z=-25f;
		float sign = 1f;
		if (Mathf.Sin (Mathf.Deg2Rad * i) < 0) {
			sign = 1f;
		} else {
			sign = -1f;
		}

		float r = 50f;
		float y = r*Mathf.Cos(Mathf.Deg2Rad*i);
		float x = (sign)*Mathf.Pow((Mathf.Pow(r,2) - Mathf.Pow(y,2)),0.5f);
		i = i + 0.5f;
		transform.position = new Vector3 (x+posOfOrbit_x, y + posOfOrbit_y, x + posOfOrbit_z);
	}
}
