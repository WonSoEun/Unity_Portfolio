using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Subject_Data : MonoBehaviour
{
    public Text Subject_Text_1;
    public Text Subject_Text_2;
    public Text Subject_Text_3;
    public Text Subject_Text_4;
    public Text Subject_Text_5;
    public Text Subject_Text_6;

    

    void Start()
    {
        if (DataManager.restart)
        {
            Debug.Log("dㄱㄶㅇㄴ");
            Subject_Text_1.text = DataSave.subject1;
            Subject_Text_2.text = DataSave.subject2;
            Subject_Text_3.text = DataSave.subject3;
            Subject_Text_4.text = DataSave.subject4;
            Subject_Text_5.text = DataSave.subject5;
            Subject_Text_6.text = DataSave.subject6;
            Debug.Log(Subject_Text_1.text);
        }
    }

    
    void Update()
    {
        
    }

    public void Subject_1()
    {
        if (Subject_textManager.class_Num == 1)
        {
            Subject_Text_1.text = "VR게임앱정보능력";
            DataSave.subject1 = "VR게임앱정보능력";
        }
        if (Subject_textManager.class_Num == 2)
        {
            Subject_Text_1.text = "HTML5";
            DataSave.subject1 = "HTML5";
        }
        if (Subject_textManager.class_Num == 3)
        {
            Subject_Text_1.text = "하이브리드앱";
            DataSave.subject1 = "하이브리드앱";
        }
        if (Subject_textManager.class_Num == 4)
        {
            Subject_Text_1.text = "반응형웹";
            DataSave.subject1 = "반응형웹";
        }

    }

    public void Subject_1_Set()
    {
        Subject_Text_1.text = "";
        DataSave.subject1 = "";
    }

    public void Subject_2()
    {
        if (Subject_textManager.class_Num == 1)
        {
            Subject_Text_2.text = "C 프로그래밍";
            DataSave.subject2 = "C 프로그래밍";
        }
        if (Subject_textManager.class_Num == 2)
        {
            Subject_Text_2.text = "안드로이드 프로그래밍";
            DataSave.subject2 = "안드로이드 프로그래밍";
        }
        if (Subject_textManager.class_Num == 3)
        {
            Subject_Text_2.text = "VR게임엔진프로그래밍";
            DataSave.subject2 = "VR게임엔진프로그래밍";
        }
        if (Subject_textManager.class_Num == 4)
        {
            Subject_Text_2.text = "UI/UX디자인";
            DataSave.subject2 = "UI/UX디자인";
        }
    }
    public void Subject_2_Set()
    {
        Subject_Text_2.text = "";
        DataSave.subject2 = "";
    }
    public void Subject_3()
    {
        if (Subject_textManager.class_Num == 1)
        {
            Subject_Text_3.text = "파이선 프로그래밍";
            DataSave.subject3 = "파이선 프로그래밍";
        }
        if (Subject_textManager.class_Num == 2)
        {
            Subject_Text_3.text = "게임 알고리즘";
            DataSave.subject3 = "게임 알고리즘";
        }
        if (Subject_textManager.class_Num == 3)
        {
            Subject_Text_3.text = "VR게임개발프로젝트";
            DataSave.subject3 = "VR게임개발프로젝트";
        }
        if (Subject_textManager.class_Num == 4)
        {
            Subject_Text_3.text = "VR,AR콘텐츠제작";
            DataSave.subject3 = "VR,AR콘텐츠제작";
        }

    }
    public void Subject_3_Set()
    {
        Subject_Text_3.text = "";
        DataSave.subject3 = "";
    }
    public void Subject_4()
    {
        if (Subject_textManager.class_Num == 1)
        {
            Subject_Text_4.text = "JAVA 기초";
            DataSave.subject4 = "JAVA 기초";
        }
        if (Subject_textManager.class_Num == 2)
        {
            Subject_Text_4.text = "게임엔진응용";
            DataSave.subject4 = "게임엔진응용";
        }
        if (Subject_textManager.class_Num == 3)
        {
            Subject_Text_4.text = "3D그래픽디자인";
            DataSave.subject4 = "3D그래픽디자인";
        }
        if (Subject_textManager.class_Num == 4)
        {
            Subject_Text_4.text = "포트폴리오";
            DataSave.subject4 = "포트폴리오";
        }


    }
    public void Subject_4_Set()
    {
        Subject_Text_4.text = "";
        DataSave.subject4 = "";
    }
    public void Subject_5()
    {
        if (Subject_textManager.class_Num == 1)
        {
            Subject_Text_5.text = "안드로이드 기초";
            DataSave.subject5 = "안드로이드 기초";
        }
        if (Subject_textManager.class_Num == 2)
        {
            Subject_Text_5.text = "컴퓨터그래픽스";
            DataSave.subject5 = "컴퓨터그래픽스";
        }
        if (Subject_textManager.class_Num == 3)
        {
            Subject_Text_5.text = "앱개발창업";
            DataSave.subject5 = "앱개발창업";
        }
        if (Subject_textManager.class_Num == 4)
        {
            Subject_Text_5.text = "캡스톤디자인";
            DataSave.subject5 = "캡스톤디자인";
        }
    }
    public void Subject_5_Set()
    {
        Subject_Text_5.text = "";
        DataSave.subject5 = "";
    }
    public void Subject_6()
    {
        if (Subject_textManager.class_Num == 1)
        {
            Subject_Text_6.text = "스크래치 프로그래밍";
            DataSave.subject6 = "스크래치 프로그래밍";
        }
        if (Subject_textManager.class_Num == 2)
        {
            Subject_Text_6.text = "앱개발";
            DataSave.subject6 = "앱개발";
        }
        if (Subject_textManager.class_Num == 3)
        {
            Subject_Text_6.text = "VR영상편집";
            DataSave.subject6 = "VR영상편집";
        }
        if (Subject_textManager.class_Num == 4)
        {
            Subject_Text_6.text = "현장실습";
            DataSave.subject6 = "현장실습";
        }
    }
    public void Subject_6_Set()
    {
        Subject_Text_6.text = "";
        DataSave.subject6 = "";
    }

    public void Coordinize()
    {
        if (Subject_Text_1.text == "" || DataSave.subject1 == "")
        {
            Subject_Text_1.text = Subject_Text_2.text;
            Subject_Text_2.text = "";

            DataSave.subject1 = DataSave.subject2;
            DataSave.subject2 = "";
        }
        if (Subject_Text_2.text == "" || DataSave.subject2 == "")
        {
            Subject_Text_2.text = Subject_Text_3.text;
            Subject_Text_3.text = "";

            DataSave.subject2 = DataSave.subject3;
            DataSave.subject3 = "";
        }
            
        if (Subject_Text_3.text == "" || DataSave.subject3 == "")
        {
            Subject_Text_3.text = Subject_Text_4.text;
            Subject_Text_4.text = "";

            DataSave.subject3 = DataSave.subject4;
            DataSave.subject4 = "";
        }
           
        if (Subject_Text_4.text == "" || DataSave.subject4 == "")
        {
            Subject_Text_4.text = Subject_Text_5.text;
            Subject_Text_5.text = "";

            DataSave.subject4 = DataSave.subject5;
            DataSave.subject5 = "";
        }
            
        if (Subject_Text_5.text == "" || DataSave.subject5 == "")
        {
            Subject_Text_5.text = Subject_Text_6.text;
            Subject_Text_6.text = "";

            DataSave.subject5 = DataSave.subject6;
            DataSave.subject6 = "";
        }
            

    }
}
