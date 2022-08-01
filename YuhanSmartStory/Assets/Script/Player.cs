using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Sprite[] player_shape; // 캐릭터 이미지 변경하는 배열

    SpriteRenderer sp;

    public DataManager data;

    void Start()
    {
        sp = GetComponent<SpriteRenderer>();
        //gameObject.transform.position = new Vector3(0, -3.5f, 0); 
        //synopsis에서의 player 위치
        if(DataManager.restart)
        {
            restart_Player();
        }
    }

    void Update()
    {
        //data = GameObject.Find("GameManager").GetComponent<DataManager>();
        if (CharacterManager.MW == "M")
        {
            if (CharacterManager.NO == "N")
            {
                sp.sprite = player_shape[0]; //남자신입생 sprite 설정  
            }
            if (CharacterManager.NO == "O")
            {
                sp.sprite = player_shape[1]; //남자복학생 sprite 설정
            }
        }
        if (CharacterManager.MW == "W")
        {
            if (CharacterManager.NO == "N")
            {
                sp.sprite = player_shape[2]; //여자신입생 sprite 설정
            }
            if (CharacterManager.NO == "O")
            {
                sp.sprite = player_shape[3]; //여자복학생 sprite 설정
            }
        }

    }

    public void restart_Player()
    {
        if (CharacterManager.MW == "M")
        {
            if (CharacterManager.NO == "N")
            {
                sp.sprite = player_shape[0]; //남자신입생 sprite 설정  
            }
            if (CharacterManager.NO == "O")
            {
                sp.sprite = player_shape[1]; //남자복학생 sprite 설정
            }
        }
        if (CharacterManager.MW == "W")
        {
            if (CharacterManager.NO == "N")
            {
                sp.sprite = player_shape[2]; //여자신입생 sprite 설정
            }
            if (CharacterManager.NO == "O")
            {
                sp.sprite = player_shape[3]; //여자복학생 sprite 설정
            }
        }
    }
}
