using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DataManager : MonoBehaviour
{
    public Image bar_physical; // 체력바 이미지
    public Image bar_stress; // 스트레스바 이미지
    public Image bar_volition; // 의지바 이미지
    public Image bar_creative; // 창의력바 이미지
    public Image bar_thinking; // 사고력바 이미지
    public Image bar_knowledge; // 지식바 이미지

    public static bool restart = false;
    int start;

    void Start()
    { //처음 능력치 세팅
        if (start == 0 && !restart)
            set_start();
        else if(restart)
        {
            bar_physical.fillAmount = DataSave.a;
            bar_stress.fillAmount = DataSave.b;
            bar_volition.fillAmount = DataSave.c;
            bar_creative.fillAmount = DataSave.d;
            bar_thinking.fillAmount = DataSave.e;
            bar_knowledge.fillAmount = DataSave.f;
        }
    }

    void Update()
    {
        
    }

    
   
    public void set_start() //처음 세팅 능력치(1번만 실행되게끔)
    {
        bar_physical.fillAmount = 1;
        bar_stress.fillAmount = 0;
        bar_volition.fillAmount = 0;
        bar_creative.fillAmount = 0.6f;
        bar_thinking.fillAmount = 0.6f;
        bar_knowledge.fillAmount = 0.6f;
        start += 1; 
    }

    public void Faithful() // '성실한'을 선택했을 시 해당 능력치 표시함.
    {
        bar_physical.fillAmount = 0.9f;
        bar_stress.fillAmount = 0.2f;
        bar_volition.fillAmount = 0.2f;
        bar_creative.fillAmount = 0.6f;
        bar_thinking.fillAmount = 0.6f;
        bar_knowledge.fillAmount = 0.6f;
    }

    public void Joyful() // '즐거운'을 선택했을 시 해당 능력치 표시함.
    {
        bar_physical.fillAmount = 0.9f;
        bar_stress.fillAmount = 0.2f;
        bar_volition.fillAmount = 0;
        bar_creative.fillAmount = 0.6f;
        bar_thinking.fillAmount = 0.6f;
        bar_knowledge.fillAmount = 0.6f;
    }

    public void Proper() // '적당한'을 선택했을 시 해당 능력치 표시함.
    {
        bar_physical.fillAmount = 1;
        bar_stress.fillAmount = 0;
        bar_volition.fillAmount = 0;
        bar_creative.fillAmount = 0.6f;
        bar_thinking.fillAmount = 0.6f;
        bar_knowledge.fillAmount = 0.6f;
    }

    public void Excellent() // '우수한'을 선택했을 시 해당 능력치 표시함.
    {
        bar_physical.fillAmount = 1;
        bar_stress.fillAmount = 0.2f;
        bar_volition.fillAmount = 0;
        bar_creative.fillAmount = 0.7f;
        bar_thinking.fillAmount = 0.7f;
        bar_knowledge.fillAmount = 0.7f;
    }

    public void Dishonesty() // '불성실한'을 선택했을 시 해당 능력치 표시함.
    {
        bar_physical.fillAmount = 1;
        bar_stress.fillAmount = 0.3f;
        bar_volition.fillAmount = 0;
        bar_creative.fillAmount = 0.6f;
        bar_thinking.fillAmount = 0.6f;
        bar_knowledge.fillAmount = 0.6f;
    }

    public void Glutinoues() // '끈기있는'을 선택했을 시 해당 능력치 표시함.
    {
        bar_physical.fillAmount = 0.9f;
        bar_stress.fillAmount = 0.1f;
        bar_volition.fillAmount = 0.3f;
        bar_creative.fillAmount = 0.6f;
        bar_thinking.fillAmount = 0.6f;
        bar_knowledge.fillAmount = 0.6f;
    }

    public void Unthinking() // '생각이 없는'을 선택했을 시 해당 능력치 표시함.
    {
        bar_physical.fillAmount = 1;
        bar_stress.fillAmount = 0.2f;
        bar_volition.fillAmount = 0;
        bar_creative.fillAmount = 0.5f;
        bar_thinking.fillAmount = 0.5f;
        bar_knowledge.fillAmount = 0.5f;
    }
}
