using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour
{
	public PlayerMovement movement; 
	public AudioSource fartSound; 
	public float upwardsForce = 1000f; 
	public Rigidbody rb;  

	void Start () {
		fartSound = GetComponent<AudioSource> (); 
	}

	void OnCollisionEnter(Collision collisionInfo) 
	{			
		if(collisionInfo.collider.tag == "Obstacle") 
		{
			rb.constraints = RigidbodyConstraints.None;
			fartSound.Play();  
			rb.AddForce(15f, 15f, 50f,  ForceMode.VelocityChange); 
			movement.enabled = false; 
			FindObjectOfType<GameManager>().EndGame(); 

		}
	}
}
