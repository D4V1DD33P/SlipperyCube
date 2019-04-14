using UnityEngine;

public class EndTrigger : MonoBehaviour
{
	public GameManager gameManager; 
	public Transform player; 

	void OnTriggerEnter()
	{
		gameManager.CompleteLevel(); 
	}

    void FixedUpdate()
    {        
       transform.Translate(Vector3.forward * 20 * Time.deltaTime);
   	}
}
