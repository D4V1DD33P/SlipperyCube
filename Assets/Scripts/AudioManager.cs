using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement; 
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource _audioSource;
    //StopCoroutine (fadeSound1);

    private void Awake()
     {          
        Debug.Log("Awake");
        _audioSource = GetComponent<AudioSource>();

        //IEnumerator fadeSound1 = AudioFadeOut.FadeOut (_audioSource, 0.5f);
   
        //_audioSource.volume -= Time.deltaTime / 1.1f;        
        if (SceneManager.GetActiveScene().buildIndex == 1) 
        { 
            _audioSource.Play();        
            //DontDestroyOnLoad(transform.gameObject);   
        }
        else if(SceneManager.GetActiveScene().buildIndex != 1)
        {
            _audioSource.Stop();
            Destroy(gameObject);
            
        }
     }
    
    void OnLevelWasLoaded()
    {
        

    }
 

    public void PlayMusic()
     {
        
         if (_audioSource.isPlaying) {
            Debug.Log("Hello");
         _audioSource.volume = 1; 
         _audioSource.Play();
         }

         if (SceneManager.GetActiveScene().buildIndex == 1)
         {
            //IEnumerator fadeSound1 = AudioFadeOut.FadeOut (_audioSource, 5f);
            StartCoroutine ("fadeSound");
            _audioSource.Stop(); 
         }
     }

    IEnumerator fadeSound() { 
        Debug.Log("fadeSound");
        while(_audioSource.volume > 0.01f) { 
            _audioSource.volume -= Time.deltaTime / 10f;
            yield return null; 

        }
        _audioSource.volume = 0; 
        _audioSource.Stop ();
    }


}
