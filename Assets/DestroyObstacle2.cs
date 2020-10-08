using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObstacle2 : MonoBehaviour
{
	public Transform player; 
	public Transform floor; 

    void FixedUpdate()
    {
        if(this.gameObject.transform.position.z < player.transform.position.z 
        	&& this.gameObject.transform.position.y > floor.transform.position.y)
        {
        	Destroy(this.gameObject);
        }
    }
}