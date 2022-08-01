using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingScene : MonoBehaviour
{
    
    public Sprite[] Ending_BG; //엔딩에서의 BG 이미지 변경하는 배열

    SpriteRenderer Ending_BG_sp;

    public static bool Excel_true = false; //true이면 하트모양 신호보내줌.
    public static bool easy_true = false;
    public static bool common_true = false;
    public static bool pullup_true = false;
    public static bool F_true = false;

    
    //bool값을 이용하여 엔딩목록을 활성화시키자.

    void Start()
    {
        Ending_BG_sp = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        

        if(EndingManager.isExcellent) //우수한 졸업
        {
            Ending_BG_sp.sprite = Ending_BG[0];
            Debug.Log("1 배경");
            Excel_true = true;
        }

        if(EndingManager.iseasy)//무난한졸업
        {
            Ending_BG_sp.sprite = Ending_BG[1];
            Debug.Log("2 배경");
            easy_true = true;
        }

        if (EndingManager.iscommon)//평범한 졸업
        {
            Ending_BG_sp.sprite = Ending_BG[2];
            Debug.Log("3 배경");
            common_true = true;
        }

        if(EndingManager.ispullUp) //간신히 턱걸이
        {
            Ending_BG_sp.sprite = Ending_BG[3];
            Debug.Log("4 배경");
            pullup_true = true;
        }

        if(EndingManager.isF) //F맞고 재수강
        {
            Ending_BG_sp.sprite = Ending_BG[4];
            Debug.Log("5 배경");
            F_true = true;
        }
    }
  
}
