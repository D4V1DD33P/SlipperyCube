﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
	public Transform player; 

	public IEnumerator Shake(float duration, float magnitude)
	{
		Vector3 originalPos = player.transform.localPosition; 
		
		float elapsed = 0.0f; 

		while(elapsed < duration)
		{
			float x = Random.Range(-0.2f, 0.2f) * magnitude; 
			float y = Random.Range(-0.1f, 0.1f) * magnitude; 

			transform.localPosition = new Vector3(originalPos.x, y-1.5f, originalPos.z+1.5f); 

			elapsed += Time.deltaTime; 

			yield return null; 
		}

		transform.localPosition = originalPos; 
	}
}