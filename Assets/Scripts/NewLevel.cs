﻿using UnityEngine;
using UnityEngine.SceneManagement; 

public class NewLevel : MonoBehaviour
{
    //Start is called before the first frame update
	public void LoadNextLevel(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
	} 
}
