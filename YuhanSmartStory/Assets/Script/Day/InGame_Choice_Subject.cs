using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InGame_Choice_Subject : MonoBehaviour
{
    public Subject_Data sub_data;

    public Text Choice_Subject;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Choice_First()
    {
        if(sub_data.Subject_Text_1.text == "VR게임앱정보능력" || sub_data.Subject_Text_1.text == "C 프로그래밍")
        {
            PopUP_IMG.c_Study = true;
        }else if(sub_data.Subject_Text_1.text == "HTML5" || sub_data.Subject_Text_1.text == "하이브리드앱" ||
            sub_data.Subject_Text_1.text == "반응형앱" || sub_data.Subject_Text_1.text == "안드로이드 프로그래밍")
        {
            PopUP_IMG.A_Study = true;
        }else if(sub_data.Subject_Text_1.text == "VR게임엔진프로그래밍")
        {
            PopUP_IMG.vr_Study = true;
        }else if(sub_data.Subject_Text_1.text == "UI/UX디자인")
        {
            PopUP_IMG.design_Study = true;
        }
    }
    public void Choice_Second()
    {
        if (sub_data.Subject_Text_2.text == "파이선 프로그래밍" || sub_data.Subject_Text_2.text == "C 프로그래밍")
        {
            PopUP_IMG.c_Study = true;
        }
        else if (sub_data.Subject_Text_2.text == "안드로이드 프로그래밍")
        {
            PopUP_IMG.A_Study = true;
        }
        else if (sub_data.Subject_Text_2.text == "VR게임개발프로젝트" || sub_data.Subject_Text_2.text == "VR,AR콘텐츠제작" ||
            sub_data.Subject_Text_2.text == "VR게임엔진프로그래밍")
        {
            PopUP_IMG.vr_Study = true;
        }
        else if (sub_data.Subject_Text_2.text == "UI/UX디자인")
        {
            PopUP_IMG.design_Study = true;
        }else if (sub_data.Subject_Text_2.text == "게임 알고리즘")
        {
            PopUP_IMG.Argori_Study = true;
        }
    }
    public void Choice_Third()
    {
        if (sub_data.Subject_Text_3.text == "파이선 프로그래밍" || sub_data.Subject_Text_3.text == "JAVA 기초")
        {
            PopUP_IMG.c_Study = true;
        }
        else if (sub_data.Subject_Text_3.text == "VR게임개발프로젝트" || sub_data.Subject_Text_3.text == "VR,AR콘텐츠제작" ||
            sub_data.Subject_Text_3.text == "게임엔진응용")
        {
            PopUP_IMG.vr_Study = true;
        }
        else if (sub_data.Subject_Text_3.text == "3D그래픽디자인")
        {
            PopUP_IMG.design_Study = true;
        }
        else if (sub_data.Subject_Text_3.text == "게임 알고리즘")
        {
            PopUP_IMG.Argori_Study = true;
        }else if(sub_data.Subject_Text_3.text == "포트폴리오")
        {
            PopUP_IMG.team_Study = true;
        }
    }
    public void Choice_Fourth()
    {
        if (sub_data.Subject_Text_4.text == "JAVA 기초")
        {
            PopUP_IMG.c_Study = true;
        }
        else if (sub_data.Subject_Text_4.text == "게임엔진응용")
        {
            PopUP_IMG.vr_Study = true;
        }
        else if (sub_data.Subject_Text_4.text == "3D그래픽디자인" || sub_data.Subject_Text_4.text == "컴퓨터그래픽스") 
        {
            PopUP_IMG.design_Study = true;
        }
        else if (sub_data.Subject_Text_4.text == "안드로이드 기초")
        {
            PopUP_IMG.A_Study = true;
        }
        else if (sub_data.Subject_Text_4.text == "포트폴리오" || sub_data.Subject_Text_4.text == "앱개발창업"
            || sub_data.Subject_Text_4.text == "캡스톤디자인")
        {
            PopUP_IMG.team_Study = true;
        }
    }
    public void Choice_Fiveth()
    {
        if (sub_data.Subject_Text_5.text == "스크래치 프로그래밍")
        {
            PopUP_IMG.vr_Study = true;
        }
        else if (sub_data.Subject_Text_5.text == "VR영상편집" || sub_data.Subject_Text_5.text == "컴퓨터그래픽스")
        {
            PopUP_IMG.design_Study = true;
        }
        else if (sub_data.Subject_Text_5.text == "안드로이드 기초")
        {
            PopUP_IMG.A_Study = true;
        }
        else if (sub_data.Subject_Text_5.text == "앱개발" || sub_data.Subject_Text_5.text == "앱개발창업"
            || sub_data.Subject_Text_5.text == "캡스톤디자인" || sub_data.Subject_Text_5.text == "현장실습")
        {
            PopUP_IMG.team_Study = true;
        }
    }


}
