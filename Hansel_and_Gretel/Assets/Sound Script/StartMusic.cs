using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMusic : MonoBehaviour
{
    GameObject bgm;
    AudioSource music;

    void Awake()
    {
        bgm = GameObject.Find("bgm");
        music = bgm.GetComponent<AudioSource>();
        music.Play();
        DontDestroyOnLoad(bgm);
    }
}