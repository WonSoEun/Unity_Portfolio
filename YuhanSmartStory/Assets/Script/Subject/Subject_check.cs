using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subject_check : MonoBehaviour
{
    public static int First_click_Num = 0; //2�� Ŭ���ϸ� üũ �������� �ϱ� ���� int������
    public static int Second_click_Num = 0;
    public static int Third_click_Num = 0;
    public static int Fourth_click_Num = 0;
    public static int Fiveth_click_Num = 0;
    public static int Sixth_click_Num = 0;

    public static int First_Subject_Num = 0;//2�� Ŭ���ϸ� ���񼳸� ���� ������� �ϱ� ���� int������
    public static int Second_Subject_Num = 0;
    public static int Third_Subject_Num = 0;
    public static int Fourth_Subject_Num = 0;
    public static int Fiveth_Subject_Num = 0;
    public static int Sixth_Subject_Num = 0;

    public static int CheckMax = 0; //���� 5���� �� �� �ְ��ϱ� ���� ����

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void First_Check()
    { //üũ�ڽ� �����ϸ� ���� ����, ���ú��� ���� ¦��,Ȧ���� ���� 5���� ���� ���
        First_click_Num++;
        if (First_click_Num % 2 == 0)
        {
            CheckMax -= 1;
        }
        else
        {
            CheckMax += 1;
        }
    }
    public void Second_Check()
    { // üũ�ڽ� �����ϸ� ���� ����, ���ú��� ���� ¦��,Ȧ���� ���� 5���� ���� ���
        Second_click_Num++;
        if (Second_click_Num % 2 == 0)
        {
            CheckMax -= 1;
        }
        else
        {
            CheckMax += 1;
        }
    }
    public void Third_Check()
    { // üũ�ڽ� �����ϸ� ���� ����, ���ú��� ���� ¦��,Ȧ���� ���� 5���� ���� ���
        Third_click_Num++;
        if (Third_click_Num % 2 == 0)
        {
            CheckMax -= 1;
        }
        else
        {
            CheckMax += 1;
        }
    }
    public void Fourth_Check()
    { // üũ�ڽ� �����ϸ� ���� ����, ���ú��� ���� ¦��,Ȧ���� ���� 5���� ���� ���
        Fourth_click_Num++;
        if (Fourth_click_Num % 2 == 0)
        {
            CheckMax -= 1;
        }
        else
        {
            CheckMax += 1;
        }
    }
    public void Fiveth_Check()
    { // üũ�ڽ� �����ϸ� ���� ����, ���ú��� ���� ¦��,Ȧ���� ���� 5���� ���� ���
        Fiveth_click_Num++;
        if (Fiveth_click_Num % 2 == 0)
        {
            CheckMax -= 1;
        }
        else
        {
            CheckMax += 1;
        }
    }
    public void Sixth_Check()
    { // üũ�ڽ� �����ϸ� ���� ����, ���ú��� ���� ¦��,Ȧ���� ���� 5���� ���� ���
        Sixth_click_Num++;
        if (Sixth_click_Num % 2 == 0)
        {
            CheckMax -= 1;
        }
        else
        {
            CheckMax += 1;
        }
    }

    public void First_Subject_EX() // ���񼳸�â �����ϸ� ���� ����
    {
        First_Subject_Num++;
    }
    public void Second_Subject_EX() // ���񼳸�â �����ϸ� ���� ����
    {
        Second_Subject_Num++;
    }
    public void Third_Subject_EX() // ���񼳸�â �����ϸ� ���� ����
    {
        Third_Subject_Num++;
    }
    public void Fourth_Subject_EX() // ���񼳸�â �����ϸ� ���� ����
    {
        Fourth_Subject_Num++;
    }
    public void Fiveth_Subject_EX() // ���񼳸�â �����ϸ� ���� ����
    {
        Fiveth_Subject_Num++;
    }
    public void Sixth_Subject_EX() // ���񼳸�â �����ϸ� ���� ����
    {
        Sixth_Subject_Num++;
    }


}
