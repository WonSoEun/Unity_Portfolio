using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subject_check : MonoBehaviour
{
    public static int First_click_Num = 0; //2번 클릭하면 체크 없어지게 하기 위한 int변수들
    public static int Second_click_Num = 0;
    public static int Third_click_Num = 0;
    public static int Fourth_click_Num = 0;
    public static int Fiveth_click_Num = 0;
    public static int Sixth_click_Num = 0;

    public static int First_Subject_Num = 0;//2번 클릭하면 과목설명 상자 사라지게 하기 위한 int변수들
    public static int Second_Subject_Num = 0;
    public static int Third_Subject_Num = 0;
    public static int Fourth_Subject_Num = 0;
    public static int Fiveth_Subject_Num = 0;
    public static int Sixth_Subject_Num = 0;

    public static int CheckMax = 0; //과목 5개만 고를 수 있게하기 위한 변수

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void First_Check()
    { //체크박스 선택하면 변수 증가, 선택변수 값이 짝수,홀수에 따라 5과목 변수 계산
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
    { // 체크박스 선택하면 변수 증가, 선택변수 값이 짝수,홀수에 따라 5과목 변수 계산
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
    { // 체크박스 선택하면 변수 증가, 선택변수 값이 짝수,홀수에 따라 5과목 변수 계산
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
    { // 체크박스 선택하면 변수 증가, 선택변수 값이 짝수,홀수에 따라 5과목 변수 계산
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
    { // 체크박스 선택하면 변수 증가, 선택변수 값이 짝수,홀수에 따라 5과목 변수 계산
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
    { // 체크박스 선택하면 변수 증가, 선택변수 값이 짝수,홀수에 따라 5과목 변수 계산
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

    public void First_Subject_EX() // 과목설명창 선택하면 변수 증가
    {
        First_Subject_Num++;
    }
    public void Second_Subject_EX() // 과목설명창 선택하면 변수 증가
    {
        Second_Subject_Num++;
    }
    public void Third_Subject_EX() // 과목설명창 선택하면 변수 증가
    {
        Third_Subject_Num++;
    }
    public void Fourth_Subject_EX() // 과목설명창 선택하면 변수 증가
    {
        Fourth_Subject_Num++;
    }
    public void Fiveth_Subject_EX() // 과목설명창 선택하면 변수 증가
    {
        Fiveth_Subject_Num++;
    }
    public void Sixth_Subject_EX() // 과목설명창 선택하면 변수 증가
    {
        Sixth_Subject_Num++;
    }


}
