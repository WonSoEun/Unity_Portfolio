using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock_true : MonoBehaviour
{
   
    void Awake()
    {
        AudioSource audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.mute = false;
        audioSource.loop = false;
        audioSource.playOnAwake = false;
    }

   
    void Update()
    {
        
    }
}
