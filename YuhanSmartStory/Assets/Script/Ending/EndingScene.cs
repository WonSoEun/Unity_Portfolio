using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingScene : MonoBehaviour
{
    
    public Sprite[] Ending_BG; //���������� BG �̹��� �����ϴ� �迭

    SpriteRenderer Ending_BG_sp;

    public static bool Excel_true = false; //true�̸� ��Ʈ��� ��ȣ������.
    public static bool easy_true = false;
    public static bool common_true = false;
    public static bool pullup_true = false;
    public static bool F_true = false;

    
    //bool���� �̿��Ͽ� ��������� Ȱ��ȭ��Ű��.

    void Start()
    {
        Ending_BG_sp = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        

        if(EndingManager.isExcellent) //����� ����
        {
            Ending_BG_sp.sprite = Ending_BG[0];
            Debug.Log("1 ���");
            Excel_true = true;
        }

        if(EndingManager.iseasy)//����������
        {
            Ending_BG_sp.sprite = Ending_BG[1];
            Debug.Log("2 ���");
            easy_true = true;
        }

        if (EndingManager.iscommon)//����� ����
        {
            Ending_BG_sp.sprite = Ending_BG[2];
            Debug.Log("3 ���");
            common_true = true;
        }

        if(EndingManager.ispullUp) //������ �ΰ���
        {
            Ending_BG_sp.sprite = Ending_BG[3];
            Debug.Log("4 ���");
            pullup_true = true;
        }

        if(EndingManager.isF) //F�°� �����
        {
            Ending_BG_sp.sprite = Ending_BG[4];
            Debug.Log("5 ���");
            F_true = true;
        }
    }
  
}
