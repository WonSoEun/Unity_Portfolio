using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BGControl : MonoBehaviour
{
    public UnityEvent onStartScrollBG; //���ӵ� ���� �̺�Ʈ

    public UnityEvent onEndScrollBG; //���� ���� �̺�Ʈ


    void Start()
    {
        
    }

    void Update()
    {
        if(GameManager.gm.state==GameState.GamePlay)
        {
            onScrollSpeed(); //���ѹݺ��� ���� speed ��ŭ ��� scroll �ǰ� �� (������)
        }

        if (GameManager.gm.state == GameState.GameOver)
        {
            EndScrollSpeed(); //���ѹݺ��� ���� speed ��ŭ ��� scroll �ǰ� �� (������)
        }
    }

    public void onScrollSpeed()
    {
        onStartScrollBG.Invoke(); //scrollspeed ���� �̺�Ʈ
    }

    public void EndScrollSpeed()
    {
        onEndScrollBG.Invoke();
    }
    
}
