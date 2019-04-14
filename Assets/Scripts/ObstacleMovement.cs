using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class ObstacleMovement : MonoBehaviour
{
    public Rigidbody rb; 
	public float forwardForce = 2000f;  
	public float moveSpeed; 

	void Start()
	{
		moveSpeed = 50f ;
	}
    // Update is called once per frame
    void FixedUpdate()
    {        
       rb.AddForce(0, 0, -forwardForce * Time.deltaTime);
   	}
        	
}

