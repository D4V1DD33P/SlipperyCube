using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] obstacles; 
    public Vector3 spawnValues;
    public float spawnWait; 
    public float spawnMostWait;
    public float spawnLeastWait; 
    public int startWait;
    public bool stop;
    public Transform end;
    int randObstacle; 

    void Start()
    {
        StartCoroutine(WaitSpawner()); 
    }

    void Update()
    {
        spawnWait = Random.Range(spawnLeastWait, spawnMostWait); 
        if(end.transform.position.z < 250) 
        {
        	Destroy(this.gameObject);
        }
    }

    IEnumerator WaitSpawner() 
    {
    	yield return new WaitForSeconds(startWait); 
    	while(!stop)
    	{
    		randObstacle = Random.Range(0,2); 
    		Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x),Random.Range(spawnValues.y, 2*spawnValues.y),Random.Range(spawnValues.z, 2*spawnValues.z));
    		Instantiate(obstacles[randObstacle],
    			spawnPosition + transform.TransformPoint(0,0,0), 
    			gameObject.transform.rotation
    			);
    		yield return new WaitForSeconds(spawnWait); 
    	} 
    }
}
