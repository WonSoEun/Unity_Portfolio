using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Sprite[] player_shape; // ĳ���� �̹��� �����ϴ� �迭

    SpriteRenderer sp;

    public DataManager data;

    void Start()
    {
        sp = GetComponent<SpriteRenderer>();
        //gameObject.transform.position = new Vector3(0, -3.5f, 0); 
        //synopsis������ player ��ġ
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
                sp.sprite = player_shape[0]; //���ڽ��Ի� sprite ����  
            }
            if (CharacterManager.NO == "O")
            {
                sp.sprite = player_shape[1]; //���ں��л� sprite ����
            }
        }
        if (CharacterManager.MW == "W")
        {
            if (CharacterManager.NO == "N")
            {
                sp.sprite = player_shape[2]; //���ڽ��Ի� sprite ����
            }
            if (CharacterManager.NO == "O")
            {
                sp.sprite = player_shape[3]; //���ں��л� sprite ����
            }
        }

    }

    public void restart_Player()
    {
        if (CharacterManager.MW == "M")
        {
            if (CharacterManager.NO == "N")
            {
                sp.sprite = player_shape[0]; //���ڽ��Ի� sprite ����  
            }
            if (CharacterManager.NO == "O")
            {
                sp.sprite = player_shape[1]; //���ں��л� sprite ����
            }
        }
        if (CharacterManager.MW == "W")
        {
            if (CharacterManager.NO == "N")
            {
                sp.sprite = player_shape[2]; //���ڽ��Ի� sprite ����
            }
            if (CharacterManager.NO == "O")
            {
                sp.sprite = player_shape[3]; //���ں��л� sprite ����
            }
        }
    }
}
