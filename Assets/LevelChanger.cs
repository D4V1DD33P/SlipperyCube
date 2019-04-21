using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class LevelChanger : MonoBehaviour
{
	public Animator animator; 
	private int levelToLoad; 
	public Transform end; 

	void Update() 
	{
		if(end != null && end.transform.position.z < -140) {
			FadeToNextLevel();
		}
	}
    public void FadeToNextLevel () 
    {
    	FadeToLevel(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void FadeToLevel (int levelIndex) 
    {
    	levelToLoad = levelIndex;
    	animator.SetTrigger("FadeOutTrigger"); 
    }

    public void OnFadeComplete()
    {
    	SceneManager.LoadScene(levelToLoad);
    }
}
