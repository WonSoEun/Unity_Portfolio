using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockDrop : MonoBehaviour
{
    public GameObject Drop_Before;
    public GameObject Drop_After;
    AudioSource audioSource;



    void Awake()
    {
        GetComponent<Clock_Inven>();
    }
    
    void start()
    {
        AudioSource audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.mute = false;
        audioSource.loop = false;
        audioSource.playOnAwake = false;
    }

    void Update()
    {        
        if (Clock_Inven.Clock_Drop==true)
        {
            Drop_Before.SetActive(false);
            Drop_After.SetActive(true);
        }
    }
}