using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float waitingTime;
    public bool ready;
    public GameObject cactus;
    public GameObject bird;
    public bool end;


    void Start()
    {
        ready = true;
        end = false;
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0) && ready)
        {
            ready = false;
            InvokeRepeating("MakeCactus", 1f, waitingTime); //waitingTime만큼 기다리고 1초마다 생성
            bird.GetComponent<Rigidbody>().useGravity = true;
        }
    }
    
    void MakeCactus()
    {
        Instantiate(cactus);
    }

    public void GameOver()
    {
        end = true;
        CancelInvoke("MakeCactus");
        iTween.ShakePosition(Camera.main.gameObject,
            iTween.Hash("x", 0.2, "y", 0.2, "time", 0.5f));
    }

}
