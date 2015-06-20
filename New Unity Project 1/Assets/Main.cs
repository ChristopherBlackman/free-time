using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {
	public Rigidbody mass;

	// Use this for initialization
	void Start () {
		//mass.tag = "gravity";
	
	}
	
	// Update is called once per frame
	void Update () {

		Stack stackOfMasses = new Stack ();

		for (int i=0; i< GameObject.FindGameObjectsWithTag("gravity").Length; i++) 
		{
			stackOfMasses.Push(GameObject.FindGameObjectsWithTag ("gravity")[i]);
			//Debug.Log(GameObject.FindGameObjectsWithTag ("gravity")[i]);
		}
		for (int i =0; i < GameObject.FindGameObjectsWithTag("gravity").Length; i++) 
		{
			Debug.Log(i);
			var objectOfMass = GameObject.FindGameObjectsWithTag ("gravity")[0].transform;
			var velocity = GameObject.FindGameObjectsWithTag ("gravity")[0].GetComponent<PublicVelocityData>();
			const float G = 06.67E-11f;
			
			float delta_y = objectOfMass.position.y - 0;
			float delta_x = objectOfMass.position.x - 0;
			float delta_z = objectOfMass.position.z - 0;
			
			float r = Mathf.Pow(Mathf.Pow(delta_x, 2)+Mathf.Pow(delta_y,2)+Mathf.Pow(delta_z,2),0.5f);
			
			
			float gravity = G * (1E11f) * (1) / Mathf.Pow(r,2);
			
			float gravity_y = delta_y * gravity / r;
			float gravity_x = delta_x * gravity / r;
			float gravity_z = delta_z * gravity / r;
			
			//y = y + oldGravity.y - gravity_y;
			//x = x + oldGravity.x - gravity_x;
			velocity.y = velocity.y  - gravity_y;
			velocity.x = velocity.x  - gravity_x;
			velocity.z = velocity.z  - gravity_z;
		}
		/*
		const float G = 06.67E-11f;
		
		float delta_y = transform.position.y - aPlanet.y;
		float delta_x = transform.position.x - aPlanet.x;
		float delta_z = transform.position.z - aPlanet.z;
		
		float r = Mathf.Pow(Mathf.Pow(delta_x, 2)+Mathf.Pow(delta_y,2)+Mathf.Pow(delta_z,2),0.5f);
		
		
		float gravity = G * (1E11f) * (1) / Mathf.Pow(r,2);
		
		float gravity_y = delta_y * gravity / r;
		float gravity_x = delta_x * gravity / r;
		float gravity_z = delta_z * gravity / r;
		
		//y = y + oldGravity.y - gravity_y;
		//x = x + oldGravity.x - gravity_x;
		y = y  - gravity_y;
		x = x  - gravity_x;
		z = z  - gravity_z;
		//stackOfMasses = GameObject.FindGameObjectsWithTag ("gravity");
	*/
	}
}
