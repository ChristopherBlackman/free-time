using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	
    //private Vectors of objet
    public float x =0, y=0, z=0;
    private Vector3 aPlanet = new Vector3(0f, 0f, 0f);

    // Use this for initialization
	void Start () {
        x = 0;
        y = 0;
        z = 0;
	}
	// Update is called once per frame
	void Update () {
        //Debug.Log(transform.position.x);
        //velecity of object

		//Gameobject[] satilite = GameObject.FindGameObjectsWithTag ("satilite");
		//Debug.Log(satilite [0]);

            //oldGravity = new Vector3(gravity_x, gravity_y, gravity_z);
		/*
        //determines velocity in +X direction
        if (Input.GetKeyDown("up")) 
        {
            y = y + velocity;
        }
        else if (Input.GetKeyUp("up")) 
        {
            //y = y - velocity;
        }
        //determines velocity in -X direction
        if (Input.GetKeyDown("down"))
        {
            y = y - velocity;
        }
        else if (Input.GetKeyUp("down"))
        {
            //y = y + velocity;
        }
        //determines velocity in +Y direction
        if (Input.GetKeyDown("right"))
        {
            x = x + velocity;
        }
        else if (Input.GetKeyUp("right"))
        {
            //x = x - velocity;
        }
        //determines velocity in -Y direction
        if (Input.GetKeyDown("left"))
        {
            x = x - velocity;
        }
        else if (Input.GetKeyUp("left"))
        {
            //x = x + velocity;
        }

        if (Input.GetKeyDown("w"))
        {
            z = z + velocity;
        }
        else if (Input.GetKeyUp("w"))
        {
            //z = z - velocity;
        }
        //determines velocity in -Y direction
        if (Input.GetKeyDown("s"))
        {
            z = z - velocity;
        }
        else if (Input.GetKeyUp("s"))
        {
            //z = z + velocity;
        }
        */
		float velocity = 0.01f;

		//determines velocity in +X direction
		if (Input.GetKey(KeyCode.LeftShift)) 
		{
			velocity = 0.001f;
		}
		if (Input.GetKey("up")) 
		{
			y = y + velocity;
		}
		//determines velocity in -X direction
		if (Input.GetKey(KeyCode.DownArrow))
		{
			y = y - velocity;
		}
		//determines velocity in +Y direction
		if (Input.GetKey(KeyCode.RightArrow))
		{
			x = x + velocity;
		}
		//determines velocity in -Y direction
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			x = x - velocity;
		}
		
		if (Input.GetKey(KeyCode.W))
		{
			z = z + velocity;
		}
		//determines velocity in -Y direction
		if (Input.GetKey(KeyCode.S))
		{
			z = z - velocity;
		}
        //if (transform.position.y > 40 || transform.position.y < -40 || transform.position.x > 75 || transform.position.x < -75)
        //{
        //    resetPos();
        //}
        if (Input.GetKeyDown(KeyCode.Space))
        {
            resetPos();
        }
        //Preforms Move
		transform.Translate(x,y,z);
        if (Input.GetKeyDown(KeyCode.Escape)) 
        { 
            Application.Quit(); 
        }

        

	}
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enter");
        resetPos();
        //transform.position = new Vector3(0f, 25f, 0f);
        //aPlanet = new Vector3(other.gameObject.transform.position.x, other.gameObject.transform.position.y, other.gameObject.transform.position.z);

    }
    void OnTriggerExit(Collider other)
    {
        aPlanet = new Vector3(0,0,0);
        //Debug.Log("Exit");
    }
    void resetPos()
    {
        y = 0;
        x = 0;
        z = 0;
        transform.position = new Vector3(0f, 25f, 0f);

    }

}
