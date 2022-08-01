using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point_estimation : MonoBehaviour
{
    // 학점계산을 위한 스크립트
    

    public Subject_Data sub_data;

    void Start()
    {
        DataSave.sum = 0;
    }

    void Update()
    {
        DataSave.sum = DataSave.sum + DataSave.Num;
    }

      

    public void estimation_Point_Num() //총 각각 몇개의 학점을 받았는지 계산하기 위함.(졸업기준)
    {
        if (DataSave.Num >= 95) DataSave.A_Plus += 1;
        if (90 <= DataSave.Num && DataSave.Num <= 95) DataSave.A += 1;
        if (85 <= DataSave.Num && DataSave.Num <= 90) DataSave.B_Plus += 1;
        if (80 <= DataSave.Num && DataSave.Num <= 85) DataSave.B += 1;
        if (75 <= DataSave.Num && DataSave.Num <= 80) DataSave.C_Plus += 1;
        if (70 <= DataSave.Num && DataSave.Num <= 75) DataSave.C += 1;
        if (60 <= DataSave.Num && DataSave.Num <= 70) DataSave.D += 1;
        if (DataSave.Num < 60) DataSave.F += 1;

    }

    public void estimation_1_1() //1학년 1학기 학점 계산
    {
        if (sub_data.Subject_Text_1.text == "VR게임앱정보능력" || sub_data.Subject_Text_2.text == "VR게임앱정보능력" ||
            sub_data.Subject_Text_3.text == "VR게임앱정보능력" || sub_data.Subject_Text_4.text == "VR게임앱정보능력" ||
            sub_data.Subject_Text_5.text == "VR게임앱정보능력")//VR게임앱정보능력
        {
            DataSave.Num = ((DataSave.d * 100) + (DataSave.f * 100)) / 2;
            estimation_Point_Num();
        }
        if(sub_data.Subject_Text_1.text == "C 프로그래밍" || sub_data.Subject_Text_2.text == "C 프로그래밍" ||
            sub_data.Subject_Text_3.text == "C 프로그래밍" || sub_data.Subject_Text_4.text == "C 프로그래밍" ||
            sub_data.Subject_Text_5.text == "C 프로그래밍")//C프로그래밍
        {
            DataSave.Num = ((DataSave.e * 100) + (DataSave.f * 100)) / 2;
            estimation_Point_Num();
        }
        if(sub_data.Subject_Text_1.text == "파이선 프로그래밍" || sub_data.Subject_Text_2.text == "파이선 프로그래밍" ||
            sub_data.Subject_Text_3.text == "파이선 프로그래밍" || sub_data.Subject_Text_4.text == "파이선 프로그래밍" ||
            sub_data.Subject_Text_5.text == "파이선 프로그래밍")//파이선 프로그래밍
        {
            DataSave.Num = ((DataSave.d * 100) + (DataSave.f * 100)) / 2;
            estimation_Point_Num();
        }
        if(sub_data.Subject_Text_1.text == "JAVA 기초" || sub_data.Subject_Text_2.text == "JAVA 기초" ||
            sub_data.Subject_Text_3.text == "JAVA 기초" || sub_data.Subject_Text_4.text == "JAVA 기초" ||
            sub_data.Subject_Text_5.text == "JAVA 기초")//Java기초
        {
            DataSave.Num = ((DataSave.e * 100) + (DataSave.f * 100)) / 2;
            estimation_Point_Num();
        }
        if(sub_data.Subject_Text_1.text == "안드로이드 기초" || sub_data.Subject_Text_2.text == "안드로이드 기초" ||
            sub_data.Subject_Text_3.text == "안드로이드 기초" || sub_data.Subject_Text_4.text == "안드로이드 기초" ||
            sub_data.Subject_Text_5.text == "안드로이드 기초")//안드로이드기초
        {
            DataSave.Num = DataSave.f * 100;
            estimation_Point_Num();
        }
        if(sub_data.Subject_Text_1.text == "스크래치 프로그래밍" || sub_data.Subject_Text_2.text == "스크래치 프로그래밍" ||
            sub_data.Subject_Text_3.text == "스크래치 프로그래밍" || sub_data.Subject_Text_4.text == "스크래치 프로그래밍" ||
            sub_data.Subject_Text_5.text == "스크래치 프로그래밍")//스크래치 프로그래밍
        {
            DataSave.Num = DataSave.f * 100;
            estimation_Point_Num();
        }
    }
    public void estimation_1_2() //1학년 2학기 학점 계산
    {
        if (sub_data.Subject_Text_1.text == "HTML5" || sub_data.Subject_Text_2.text == "HTML5" ||
            sub_data.Subject_Text_3.text == "HTML5" || sub_data.Subject_Text_4.text == "HTML5" ||
            sub_data.Subject_Text_5.text == "HTML5")//HTML5
        {
            DataSave.Num = ((DataSave.d * 100) + (DataSave.f * 100)) / 2;
            estimation_Point_Num();
        }
        if (sub_data.Subject_Text_1.text == "안드로이드 프로그래밍" || sub_data.Subject_Text_2.text == "안드로이드 프로그래밍" ||
            sub_data.Subject_Text_3.text == "안드로이드 프로그래밍" || sub_data.Subject_Text_4.text == "안드로이드 프로그래밍" ||
            sub_data.Subject_Text_5.text == "안드로이드 프로그래밍")//안드로이드 프로그래밍
        {
            DataSave.Num = DataSave.f * 100;
            estimation_Point_Num();
        }
        if (sub_data.Subject_Text_1.text == "게임 알고리즘" || sub_data.Subject_Text_2.text == "게임 알고리즘" ||
            sub_data.Subject_Text_3.text == "게임 알고리즘" || sub_data.Subject_Text_4.text == "게임 알고리즘" ||
            sub_data.Subject_Text_5.text == "게임 알고리즘")//게임 알고리즘
        {
            DataSave.Num = ((DataSave.d * 100) + (DataSave.f * 100)) / 2;
            estimation_Point_Num();
        }
        if (sub_data.Subject_Text_1.text == "게임엔진응용" || sub_data.Subject_Text_2.text == "게임엔진응용" ||
            sub_data.Subject_Text_3.text == "게임엔진응용" || sub_data.Subject_Text_4.text == "게임엔진응용" ||
            sub_data.Subject_Text_5.text == "게임엔진응용")//게임엔진응용
        {
            DataSave.Num = DataSave.f * 100;
            estimation_Point_Num();
        }
        if (sub_data.Subject_Text_1.text == "컴퓨터그래픽스" || sub_data.Subject_Text_2.text == "컴퓨터그래픽스" ||
            sub_data.Subject_Text_3.text == "컴퓨터그래픽스" || sub_data.Subject_Text_4.text == "컴퓨터그래픽스" ||
            sub_data.Subject_Text_5.text == "컴퓨터그래픽스")//컴퓨터그래픽스
        {
            DataSave.Num = ((DataSave.e * 100) + (DataSave.f * 100)) / 2;
            estimation_Point_Num();
        }
        if (sub_data.Subject_Text_1.text == "앱개발" || sub_data.Subject_Text_2.text == "앱개발" ||
            sub_data.Subject_Text_3.text == "앱개발" || sub_data.Subject_Text_4.text == "앱개발" ||
            sub_data.Subject_Text_5.text == "앱개발")//앱개발
        {
            DataSave.Num = ((DataSave.e * 100) + (DataSave.f * 100)) / 2;
            estimation_Point_Num();
        }
    }
    public void estimation_2_1() //2학년 1학기 학점 계산
    {
        if (sub_data.Subject_Text_1.text == "하이브리드앱" || sub_data.Subject_Text_2.text == "하이브리드앱" ||
            sub_data.Subject_Text_3.text == "하이브리드앱" || sub_data.Subject_Text_4.text == "하이브리드앱" ||
            sub_data.Subject_Text_5.text == "하이브리드앱")//하이브리드앱
        {
            DataSave.Num = ((DataSave.d * 100) + (DataSave.f * 100)) / 2;
            estimation_Point_Num();
        }
        if (sub_data.Subject_Text_1.text == "VR게임엔진프로그래밍" || sub_data.Subject_Text_2.text == "VR게임엔진프로그래밍" ||
            sub_data.Subject_Text_3.text == "VR게임엔진프로그래밍" || sub_data.Subject_Text_4.text == "VR게임엔진프로그래밍" ||
            sub_data.Subject_Text_5.text == "VR게임엔진프로그래밍")//VR게임엔진프로그래밍
        {
            DataSave.Num = ((DataSave.e * 100) + (DataSave.f * 100)) / 2;
            estimation_Point_Num();
        }
        if (sub_data.Subject_Text_1.text == "VR게임개발프로젝트" || sub_data.Subject_Text_2.text == "VR게임개발프로젝트" ||
            sub_data.Subject_Text_3.text == "VR게임개발프로젝트" || sub_data.Subject_Text_4.text == "VR게임개발프로젝트" ||
            sub_data.Subject_Text_5.text == "VR게임개발프로젝트")//VR게임개발프로젝트
        {
            DataSave.Num = ((DataSave.e * 100) + (DataSave.f * 100)) / 2;
            estimation_Point_Num();
        }
        if (sub_data.Subject_Text_1.text == "3D그래픽디자인" || sub_data.Subject_Text_2.text == "3D그래픽디자인" ||
            sub_data.Subject_Text_3.text == "3D그래픽디자인" || sub_data.Subject_Text_4.text == "3D그래픽디자인" ||
            sub_data.Subject_Text_5.text == "3D그래픽디자인")//3D그래픽디자인
        {
            DataSave.Num = ((DataSave.d * 100) + (DataSave.f * 100)) / 2;
            estimation_Point_Num();
        }
        if (sub_data.Subject_Text_1.text == "앱개발창업" || sub_data.Subject_Text_2.text == "앱개발창업" ||
            sub_data.Subject_Text_3.text == "앱개발창업" || sub_data.Subject_Text_4.text == "앱개발창업" ||
            sub_data.Subject_Text_5.text == "앱개발창업")//앱개발창업
        {
            DataSave.Num = DataSave.f * 100;
            estimation_Point_Num();
        }
        if (sub_data.Subject_Text_1.text == "VR영상편집" || sub_data.Subject_Text_2.text == "VR영상편집" ||
            sub_data.Subject_Text_3.text == "VR영상편집" || sub_data.Subject_Text_4.text == "VR영상편집" ||
            sub_data.Subject_Text_5.text == "VR영상편집")//VR영상편집
        {
            DataSave.Num = DataSave.f * 100;
            estimation_Point_Num();
        }
    }

    public void estimation_2_2() //2학년 2학기 학점 계산
    {
        if (sub_data.Subject_Text_1.text == "반응형웹" || sub_data.Subject_Text_2.text == "반응형웹" ||
            sub_data.Subject_Text_3.text == "반응형웹" || sub_data.Subject_Text_4.text == "반응형웹" ||
            sub_data.Subject_Text_5.text == "반응형웹")//반응형웹
        {
            DataSave.Num = ((DataSave.d * 100) + (DataSave.f * 100)) / 2;
            estimation_Point_Num();
        }
        if (sub_data.Subject_Text_1.text == "UI/UX디자인" || sub_data.Subject_Text_2.text == "UI/UX디자인" ||
            sub_data.Subject_Text_3.text == "UI/UX디자인" || sub_data.Subject_Text_4.text == "UI/UX디자인" ||
            sub_data.Subject_Text_5.text == "UI/UX디자인")//UI/UX디자인
        {
            DataSave.Num = ((DataSave.e * 100) + (DataSave.f * 100)) / 2;
            estimation_Point_Num();
        }
        if (sub_data.Subject_Text_1.text == "VR,AR콘텐츠제작" || sub_data.Subject_Text_2.text == "VR,AR콘텐츠제작" ||
            sub_data.Subject_Text_3.text == "VR,AR콘텐츠제작" || sub_data.Subject_Text_4.text == "VR,AR콘텐츠제작" ||
            sub_data.Subject_Text_5.text == "VR,AR콘텐츠제작")//VR,AR콘텐츠제작
        {
            DataSave.Num = DataSave.f * 100;
            estimation_Point_Num();
        }
        if (sub_data.Subject_Text_1.text == "포트폴리오" || sub_data.Subject_Text_2.text == "포트폴리오" ||
            sub_data.Subject_Text_3.text == "포트폴리오" || sub_data.Subject_Text_4.text == "포트폴리오" ||
            sub_data.Subject_Text_5.text == "포트폴리오")//포트폴리오
        {
            DataSave.Num = DataSave.f * 100;
            estimation_Point_Num();
        }
        if (sub_data.Subject_Text_1.text == "캡스톤디자인" || sub_data.Subject_Text_2.text == "캡스톤디자인" ||
            sub_data.Subject_Text_3.text == "캡스톤디자인" || sub_data.Subject_Text_4.text == "캡스톤디자인" ||
            sub_data.Subject_Text_5.text == "캡스톤디자인")//캡스톤디자인
        {
            DataSave.Num = ((DataSave.d * 100) + (DataSave.f * 100)) / 2;
            estimation_Point_Num();
        }
        if (sub_data.Subject_Text_1.text == "현장실습" || sub_data.Subject_Text_2.text == "현장실습" ||
            sub_data.Subject_Text_3.text == "현장실습" || sub_data.Subject_Text_4.text == "현장실습" ||
            sub_data.Subject_Text_5.text == "현장실습")//현장실습
        {
            DataSave.Num = ((DataSave.e * 100) + (DataSave.f * 100)) / 2;
            estimation_Point_Num();
        }
    }
}
