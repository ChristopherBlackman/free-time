using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	
    //private Vectors of objet
    private float x, y, z;
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
        const float velocity = 0.1f;
        const float G = 06.67E-11f;
        
            float delta_y = transform.position.y - aPlanet.y;
            float delta_x = transform.position.x - aPlanet.x;
            float delta_z = transform.position.z - aPlanet.z;

            float r = Mathf.Pow(Mathf.Pow(delta_x, 2)+Mathf.Pow(delta_y,2)+Mathf.Pow(delta_z,2),0.5f);


            float gravity = G * (1E10f) * (1) / Mathf.Pow(r,2);

            float gravity_y = delta_y * gravity / r;
            float gravity_x = delta_x * gravity / r;
            float gravity_z = delta_z * gravity / r;

            //y = y + oldGravity.y - gravity_y;
            //x = x + oldGravity.x - gravity_x;
            y = y  - gravity_y;
            x = x  - gravity_x;
            z = z  - gravity_z;

            //oldGravity = new Vector3(gravity_x, gravity_y, gravity_z);

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
        //if (transform.position.y > 40 || transform.position.y < -40 || transform.position.x > 75 || transform.position.x < -75)
        //{
        //    resetPos();
        //}
        if (Input.GetKeyDown("space"))
        {
            resetPos();
        }
        //Preforms Move
        transform.Translate(x,y,z);
        if (Input.GetKeyDown("escape")) 
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
        Debug.Log("Exit");
    }
    void resetPos()
    {
        y = 0;
        x = 0;
        z = 0;
        transform.position = new Vector3(0f, 25f, 0f);

    }

}
