using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurtainControll : MonoBehaviour
{
    public GameObject CurtainOPEN;
    public GameObject CurtainCLOSE;
    public static int touchCount = 0;
    GameObject CurtainSound;
    AudioSource music;

    void Start()
    {
        CurtainOPEN.SetActive(false);
        CurtainCLOSE.SetActive(true);
        CurtainSound = GameObject.Find("CurtainSound");
        music = CurtainSound.GetComponent<AudioSource>();
    }
    void Update()
    {
        if(touchCount%2==0)
        {
            CurtainOPEN.SetActive(false);
            CurtainCLOSE.SetActive(true);            
        }
        else
        {
            CurtainOPEN.SetActive(true);
            CurtainCLOSE.SetActive(false);
        }
    }
    public void Curtain()
    {
        touchCount++;
        music.Play();
    }
}
