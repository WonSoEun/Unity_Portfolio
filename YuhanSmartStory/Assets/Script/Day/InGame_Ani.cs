using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGame_Ani : MonoBehaviour
{
    Animator ani;
    public ChangeState day;
    public PopUP_IMG pop;
    public SleepIMG sleepImg;


    public bool is_End_Ani = false;
    public bool end = false;

    void Start()
    {
        ani = GetComponent<Animator>();
    }

    void Update()
    {
        if (sleepImg.is_sleep_Week)
        {
            ani.SetTrigger("Sleeping");
            sleepImg.is_sleep_Week = false;
            Invoke("End_ani",1f);
        }
        if(is_End_Ani)
        {
            ani.SetTrigger("End_Ani");
            end = true;
        }
    }

    public void PF_Ani()
    {
        if (GameManager.is_Fail)
        {
            ani.SetTrigger("Study_Fail");
            Invoke("End_ani", 2f);
        }
        if (GameManager.is_Perfect)
        {
            ani.SetTrigger("Study_Perfect");
            Invoke("End_ani", 2f);
            
        }
    }

    void End_ani()
    {
        is_End_Ani = true;
        if(GameManager.is_Fail || GameManager.is_Perfect) Delay_End_Ani();
        else
        {
            if (end)
            {
                sleepImg.NullSprite();
                day.Setting_Day(); //주말 휴식하기 --> 평일
            }
            
        }

    }

    void Delay_End_Ani()
    {
        if (GameManager.is_Fail)
        {
            DataSave.Week_Num += 1;
            day.Setting_Day();
            GameManager.is_Fail = false;
        }
        if (GameManager.is_Perfect)
        {
            DataSave.Week_Num += 1;
            day.Setting_Day();
            GameManager.is_Perfect = false;
        }
        Debug.Log("dkd");
        
    }
}
