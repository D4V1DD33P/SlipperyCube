using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
	public AudioSource hitSound; 

	void Start () {
		hitSound = GetComponent<AudioSource> (); 
	}

	void OnCollisionEnter(Collision collisionInfo) 
	{			
		if(collisionInfo.collider.tag == "Ground") 
		{
			hitSound.Play(); 
		}
	}
}
