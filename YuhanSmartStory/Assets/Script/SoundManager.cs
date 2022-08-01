using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance = null;

    
    private void Awake()
    {
        if (instance == null) 
        {
            instance = this;
        }else
        {
            Destroy(gameObject);
        }    
    }
    public void SoundPlay(string soundName,AudioClip clip)
    {
        GameObject play = new GameObject(soundName);
        AudioSource audioSource = play.AddComponent<AudioSource>();
        audioSource.clip = clip;
        audioSource.Play();
        Destroy(play, clip.length);
    }
}
