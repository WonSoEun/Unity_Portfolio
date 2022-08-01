using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingCharacter : MonoBehaviour
{
    public Sprite[] Ending_Player_shape; //���������� ĳ���� �̹��� �����ϴ� �迭
    
    SpriteRenderer Ending_sp;


    void Start()
    {
        Ending_sp = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if(EndingManager.isExcellent) //����� ���� 
        {
            if (CharacterManager.MW == "M")
            {
                if (CharacterManager.NO == "N")
                {
                    Ending_sp.sprite = Ending_Player_shape[0];  //����� ���ڽ��Ի� ���
                    Debug.Log("����� ���ڽ��Ի�");
                }
                if (CharacterManager.NO == "O")
                {
                    Ending_sp.sprite = Ending_Player_shape[1];//����� ���ں��л� ���
                    Debug.Log("����� ���ں��л�");
                }
            }
            if (CharacterManager.MW == "W")
            {
                if (CharacterManager.NO == "N")
                {
                    Ending_sp.sprite = Ending_Player_shape[2];//����� ���ڽ��Ի� ���
                    Debug.Log("����� ���ڽ��Ի�");
                }
                if (CharacterManager.NO == "O")
                {
                    Ending_sp.sprite = Ending_Player_shape[3];//����� ���ں��л� ���
                    Debug.Log("����� ���ں��л�");
                }
            }
        }
        
        if(EndingManager.iseasy) //������ ����
        {
            if (CharacterManager.MW == "M")
            {
                if (CharacterManager.NO == "N")
                {
                    Ending_sp.sprite = Ending_Player_shape[4];  //������ ���ڽ��Ի� ���
                    Debug.Log("������ ���ڽ��Ի�");
                }
                if (CharacterManager.NO == "O")
                {
                    Ending_sp.sprite = Ending_Player_shape[5];//������ ���ں��л� ���
                    Debug.Log("������ ���ں��л�");
                }
            }
            if (CharacterManager.MW == "W")
            {
                if (CharacterManager.NO == "N")
                {
                    Ending_sp.sprite = Ending_Player_shape[6];//������ ���ڽ��Ի� ���
                    Debug.Log("������ ���ڽ��Ի�");
                }
                if (CharacterManager.NO == "O")
                {
                    Ending_sp.sprite = Ending_Player_shape[7];//������ ���ڽ��Ի� ���
                    Debug.Log("������ ���ں��л�");
                }
            }
        }
        

        if (EndingManager.iscommon)//����� ����
        {
            Ending_sp.sprite = null;
            Debug.Log("����� ������");
        }

        if(EndingManager.ispullUp)
        {
            gameObject.transform.position = new Vector3(0, 0.6f, -1);
            if (CharacterManager.MW == "M")
            {
                if (CharacterManager.NO == "N")
                {
                    Ending_sp.sprite = Ending_Player_shape[8];  //�������ΰ��� ���ڽ��Ի� ���
                    Debug.Log("�������ΰ��� ���ڽ��Ի�");
                }
                if (CharacterManager.NO == "O")
                {
                    Ending_sp.sprite = Ending_Player_shape[9];//�������ΰ��� ���ں��л� ���
                    Debug.Log("�������ΰ��� ���ں��л�");
                }
            }
            if (CharacterManager.MW == "W")
            {
                if (CharacterManager.NO == "N")
                {
                    Ending_sp.sprite = Ending_Player_shape[10];//�������ΰ��� ���ڽ��Ի� ���
                    Debug.Log("�������ΰ��� ���ڽ��Ի�");
                }
                if (CharacterManager.NO == "O")
                {
                    Ending_sp.sprite = Ending_Player_shape[11];//�������ΰ��� ���ں��л� ���
                    Debug.Log("�������ΰ��� ���ں��л�");
                }
            }
        }
        
        if(EndingManager.isF)
        {
            gameObject.transform.position = new Vector3(-1.35f, 0, -1);
            if (CharacterManager.MW == "M")
            {
                if (CharacterManager.NO == "N")
                {
                    Ending_sp.sprite = Ending_Player_shape[12];  //F ���ڽ��Ի� ���
                    Debug.Log("F ���ڽ��Ի�");
                }
                if (CharacterManager.NO == "O")
                {
                    Ending_sp.sprite = Ending_Player_shape[13];//F ���ں��л� ���
                    Debug.Log("F ���ں��л�");
                }
            }
            if (CharacterManager.MW == "W")
            {
                if (CharacterManager.NO == "N")
                {
                    Ending_sp.sprite = Ending_Player_shape[14];//F ���ڽ��Ի� ���
                    Debug.Log("F ���ڽ��Ի�");
                }
                if (CharacterManager.NO == "O")
                {
                    Ending_sp.sprite = Ending_Player_shape[15];//F ���ں��л� ���
                    Debug.Log("F ���ں��л�");
                }
            }
        }

        

    }
}
