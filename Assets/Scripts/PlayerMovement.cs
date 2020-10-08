using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb; 
	public float forwardForce = 2000f;  
	public float sidewaysForce = 50f; 
	public float upwardsForce = 1000f; 
	public float moveSpeed; 

	void Start()
	{
		moveSpeed = 50f;
        rb.freezeRotation = true;
	}

    void FixedUpdate()
    {        
    	if(rb.position.y < -0.5f) {
        	FindObjectOfType<GameManager>().EndGame(); 
        }
        else { 
        	rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        	transform.Translate(moveSpeed*Input.GetAxis("Horizontal")*Time.deltaTime,0f,moveSpeed*Input.GetAxis("Vertical")*Time.deltaTime);
        }
        //if(Input.GetKey("d")) rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); 
        //if(Input.GetKey("a")) rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0,  ForceMode.VelocityChange); 
        //if(Input.GetKey("w")) rb.AddForce(0, upwardsForce * Time.deltaTime, 0,  ForceMode.VelocityChange); 
        //if(Input.GetKey("s")) rb.AddForce(0, -upwardsForce * Time.deltaTime, 0, ForceMode.VelocityChange); 
    }
}
