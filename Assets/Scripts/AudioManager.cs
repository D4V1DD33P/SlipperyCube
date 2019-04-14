using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement; 
using UnityEngine;

public class AudioManager : MonoBehaviour
{
private AudioSource _audioSource;
     private void Awake()
     {
         DontDestroyOnLoad(transform.gameObject);
         _audioSource = GetComponent<AudioSource>();
     }
 
     public void PlayMusic()
     {
         if (_audioSource.isPlaying) return;
         _audioSource.Play();

         //if (SceneManager.GetActiveScene().buildIndex == 1)
         //{
         //   _audioSource.Stop(); 
         //}
     }
}
