using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Sound
{
    public string soundName;
    public AudioClip clip;
}

public class SoundManager : MonoBehaviour
{
    [Header("사운드 등록")]
    [SerializeField] Sound[] bgmSounds;

    [Header("브금 플레이어")]
    [SerializeField] AudioSource bgmPlayer;

    void Start()
    {
        
    }

    public void PlayBGM()
    {

    }
   
}
