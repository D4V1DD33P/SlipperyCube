using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BlinkingText : MonoBehaviour
{
    Text text; 
    public Transform player;   
    public CameraShake cameraShake;
    public AudioSource warningSound; 

    void Start()
    {
    	text = GetComponent<Text>(); 
    	StartBlinking();
    	var movement = player.GetComponent<PlayerMovement>();
    	movement.enabled = false; 
    }

    IEnumerator Blink()
    {
    	while(true)
    	{
    		switch(text.color.a.ToString()) 
    		{
    			case "0":
    				text.color = new Color(text.color.r, text.color.g, text.color.b, 1); 
    				warningSound.Play(); 
    				//StartCoroutine(cameraShake.Shake(1f, 0f));
    				yield return new WaitForSeconds(0.7f); 
    				break;
    			case "1": 
    				text.color = new Color(text.color.r, text.color.g, text.color.b, 0); 
    				//play sound
    				yield return new WaitForSeconds(0.3f); 
    				break;
    		}
    	}
    }

    void StartBlinking()
    {
    	StopCoroutine("Blink"); 
    	StartCoroutine("Blink");
    }
    void StopBlinking()
    {
    	StopCoroutine("Blink"); 
    }
}
