using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingList_Character : MonoBehaviour
{
    public Sprite[] EndingList_Player_shape; //���������� ĳ���� �̹��� �����ϴ� �迭

    SpriteRenderer EndingList_sp;


    void Start()
    {
        EndingList_sp = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (EndingManager.isExcellent) //����� ���� 
        {
            if (CharacterManager.MW == "M")
            {
                if (CharacterManager.NO == "N")
                {
                    EndingList_sp.sprite = EndingList_Player_shape[0];  //����� ���ڽ��Ի� ���
                }
                if (CharacterManager.NO == "O")
                {
                    EndingList_sp.sprite = EndingList_Player_shape[1];//����� ���ں��л� ���
                }
            }
            if (CharacterManager.MW == "W")
            {
                if (CharacterManager.NO == "N")
                {
                    EndingList_sp.sprite = EndingList_Player_shape[2];//����� ���ڽ��Ի� ���
                }
                if (CharacterManager.NO == "O")
                {
                    EndingList_sp.sprite = EndingList_Player_shape[3];//����� ���ں��л� ���
                }
            }
        }

        if (EndingManager.iseasy) //������ ����
        {
            if (CharacterManager.MW == "M")
            {
                if (CharacterManager.NO == "N")
                {
                    EndingList_sp.sprite = EndingList_Player_shape[4];  //������ ���ڽ��Ի� ���
                }
                if (CharacterManager.NO == "O")
                {
                    EndingList_sp.sprite = EndingList_Player_shape[5];//������ ���ں��л� ���
                }
            }
            if (CharacterManager.MW == "W")
            {
                if (CharacterManager.NO == "N")
                {
                    EndingList_sp.sprite = EndingList_Player_shape[6];//������ ���ڽ��Ի� ���
                }
                if (CharacterManager.NO == "O")
                {
                    EndingList_sp.sprite = EndingList_Player_shape[7];//������ ���ڽ��Ի� ���
                }
            }
        }


        if (EndingManager.iscommon)//����� ����
        {
            EndingList_sp.sprite = null;
        }

        if (EndingManager.ispullUp)
        {
            gameObject.transform.position = new Vector3(0, 0.6f, -1);
            if (CharacterManager.MW == "M")
            {
                if (CharacterManager.NO == "N")
                {
                    EndingList_sp.sprite = EndingList_Player_shape[8];  //�������ΰ��� ���ڽ��Ի� ���
                }
                if (CharacterManager.NO == "O")
                {
                    EndingList_sp.sprite = EndingList_Player_shape[9];//�������ΰ��� ���ں��л� ���
                }
            }
            if (CharacterManager.MW == "W")
            {
                if (CharacterManager.NO == "N")
                {
                    EndingList_sp.sprite = EndingList_Player_shape[10];//�������ΰ��� ���ڽ��Ի� ���
                }
                if (CharacterManager.NO == "O")
                {
                    EndingList_sp.sprite = EndingList_Player_shape[11];//�������ΰ��� ���ں��л� ���
                }
            }
        }

        if (EndingManager.isF)
        {
            gameObject.transform.position = new Vector3(-1.35f, 0, -1);
            if (CharacterManager.MW == "M")
            {
                if (CharacterManager.NO == "N")
                {
                    EndingList_sp.sprite = EndingList_Player_shape[12];  //F ���ڽ��Ի� ���
                }
                if (CharacterManager.NO == "O")
                {
                    EndingList_sp.sprite = EndingList_Player_shape[13];//F ���ں��л� ���
                }
            }
            if (CharacterManager.MW == "W")
            {
                if (CharacterManager.NO == "N")
                {
                    EndingList_sp.sprite = EndingList_Player_shape[14];//F ���ڽ��Ի� ���
                }
                if (CharacterManager.NO == "O")
                {
                    EndingList_sp.sprite = EndingList_Player_shape[15];//F ���ں��л� ���
                }
            }
        }



    }
}
