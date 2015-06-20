using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {

	public GameObject turret;
	public GameObject gun;
	private bool rotating = true;
	// Use this for initialization
	void Start () {
		//get the component 
		turret = GameObject.Find ("Gun_1_Movable_1");
	}
	
	// Update is called once per frame
	void Update () {

		//get pos of the gun and component 
		Vector2 pos_1 = new Vector2 (transform.position.x, transform.position.y);
		Vector2 pos_2 = new Vector2 (Camera.main.ScreenPointToRay(Input.mousePosition).origin.x,Camera.main.ScreenPointToRay(Input.mousePosition).origin.y);

		//the direction vector to determine the universal degrees
		Vector2 a = new Vector2 (1.0f, 0.0f);

		//vector that gun makes with mouse
		Vector2 b = pos_2 - pos_1;

		//rotate the vector if the cursor does not hover over the gun
		if (b.magnitude > ((b.magnitude / (b.magnitude))/2)+0.1) {
			//find the angle to the 180 through dot product
			float angle = Mathf.Rad2Deg * Mathf.Acos (Vector2.Dot (a, b) / (b.magnitude * a.magnitude));

			//full 360 degree turn
			if (turret.transform.position.y < pos_2.y) {
				angle = angle;
			} else {
				angle = -angle + 360;
			}

			//angle of the component
			turret.transform.eulerAngles = new Vector3 (0.0f, 0.0f, angle - 90);

			//how far away the object will be from gun
			turret.transform.position = (pos_1 + b / b.magnitude)/2;
		}
	}
}
