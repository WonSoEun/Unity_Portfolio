using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BGControl : MonoBehaviour
{
    public UnityEvent onStartScrollBG; //가속도 실행 이벤트

    public UnityEvent onEndScrollBG; //감속 실행 이벤트


    void Start()
    {
        
    }

    void Update()
    {
        if(GameManager.gm.state==GameState.GamePlay)
        {
            onScrollSpeed(); //무한반복을 통해 speed 만큼 계속 scroll 되게 함 (에러남)
        }

        if (GameManager.gm.state == GameState.GameOver)
        {
            EndScrollSpeed(); //무한반복을 통해 speed 만큼 계속 scroll 되게 함 (에러남)
        }
    }

    public void onScrollSpeed()
    {
        onStartScrollBG.Invoke(); //scrollspeed 실행 이벤트
    }

    public void EndScrollSpeed()
    {
        onEndScrollBG.Invoke();
    }
    
}
