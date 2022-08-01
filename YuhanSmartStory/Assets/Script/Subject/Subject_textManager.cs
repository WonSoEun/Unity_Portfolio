using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Subject_textManager : MonoBehaviour
{
    public static int class_Num=1; // 학기마다 달라지는 과목 설정을 위한 조건 int값
    public static bool next_class_Num;

    public Text Semester; //학기 표기 text

    public Text Subject_1; //과목이름
    public Text Subject_2;
    public Text Subject_3;
    public Text Subject_4;
    public Text Subject_5;
    public Text Subject_6;

    public Text Subject_EX_1;//과목 설명
    public Text Subject_EX_2;
    public Text Subject_EX_3;
    public Text Subject_EX_4;
    public Text Subject_EX_5;
    public Text Subject_EX_6;
    
    void Start()
    {
        
    }


    void Update()
    {
        if (next_class_Num)
        {
            class_Num += 1;
            next_class_Num = false;
        }

        if (class_Num == 1) //1학년 1학기
        {
            Semester.text = "1학년 1학기";

            Subject_1.text = "VR게임앱정보능력";
            Subject_2.text = "C 프로그래밍";
            Subject_3.text = "파이선 프로그래밍";
            Subject_4.text = "JAVA 기초";
            Subject_5.text = "안드로이드 기초";
            Subject_6.text = "스크래치 프로그래밍";

            //VR게임앱정보능력
            Subject_EX_1.text = "과목설명\n\n직장생활에서 기본적인 컴퓨터를 활용하여 필요한 정보를 수집, 분석,활용할 수 있는 능력을 함양하는 것을 목표로 한다.";
            //C프로그래밍
            Subject_EX_2.text = "과목설명\n\nC언어를 자유자재로 프로그래밍 할 수 있는 능력을 키우고, 나아가 C++,JAVA와 같은 과목으로 연계할 수 있는 능력을 배운다.";
            //파이선 프로그래밍
            Subject_EX_3.text = "과목설명\n\n간결한 문법으로 프로그래밍 입문자가 이해하기 쉽고, 프로그래밍하기 쉬운 편리한 언어로 대중적으로 많이 활용되며 선호하는 프로그래밍 언어로 성장하고 있다.";
            //JAVA 기초
            Subject_EX_4.text = "과목설명\n\nJAVA 기초 능력뿐만 아니라 이벤트, 애플릿, 애니메이션, 입출력시스템, 네트워크 관련 기술을 현장에서 바로 투입할 수 있도록 실습위주의 수업을 진행한다.";
            //안드로이드 기초
            Subject_EX_5.text = "과목설명\n\n안드로이드 기반의 앱을 만들 수 있는 기초학문으로, 안드로이드 스튜디오 통합 환경을 이용한 앱을 설계하고, 제작할 수 있는 기술을 배운다.";
            //스크래치 프로그래밍
            Subject_EX_6.text = "과목설명\n\n게임을 개발할 수 있는 스크래치 기반의 프로그램 코딩 과정을 학습할 수 있으며, 더 효율적으로 이해할 수 있는 블록코딩을 통해 프로그래밍 기초 및 응용과정을 배울 수 있는 과목이다.";
        }
        if (class_Num == 2) //1학년 2학기
        {
            Semester.text = "1학년 2학기";

            Subject_1.text = "HTML5";
            Subject_2.text = "안드로이드 프로그래밍";
            Subject_3.text = "게임 알고리즘";
            Subject_4.text = "게임엔진응용";
            Subject_5.text = "컴퓨터그래픽스";
            Subject_6.text = "앱개발";

            //HTML5
            Subject_EX_1.text = "과목설명\n\n본 과정에서는 HTML5의 기본적인 태그를 익히고 응용할 수 있도록 설계되었으며, 기본적인 웹/앱 프로그래밍 개념을 익히고 활용할 수 있도록 설계되었다.";
            //안드로이드 프로그래밍
            Subject_EX_2.text = "과목설명\n\n안드로이드 모바일 기기를 이용하는 앱을 개발하는 과정으로, 안드로이드 OS 환경에서 안드로이드 앱을 프로그래밍 한다.";
            //게임 알고리즘
            Subject_EX_3.text = "과목설명\n\n사용자측의 게임 구동이 가능한 플랫폼에서 게임이 원활하게 작동되도록 알고리즘으로 제시할 수 있는 분야로 게임을 설계하고 알고리즘을 개발하여 실생활에 응용할 수 있도록 학습한다.";
            //게임엔진응용
            Subject_EX_4.text = "과목설명\n\n게임엔진을 통해 2D게임,3D게임과 같은 실전게임예제를 만들어본다. 게임예제를 통해 게임 내 주요기능 구현법을 학습하고 창의적, 독창적 아이디어를 실제 게임내 구현하게 된다.";
            //컴퓨터그래픽스
            Subject_EX_5.text = "과목설명\n\n본 과정에서는 캐릭터를 설계하고 표현함으로써 포토샵이나 일러스트를 통하여 작업하는 것을 배운다. 그래픽뿐만 아니라 모바일 게임분야에서 활용할 수 있는 기술을 배우고 익힌다.";
            //앱개발
            Subject_EX_6.text = "과목설명\n\n수립된 앱 개발 계획과 시스템 설계서, 제작된 UI/UX 디자인을 토대로 앱 개발 수행을 위하여 프로그래밍하고 디버깅/테스트를 실시하고 필요 시 멀티미디어를 연동하여 산출물을 작성할 수 있다.";
        }
        if (class_Num == 3) //2학년 1학기
        {
            Semester.text = "2학년 1학기";

            Subject_1.text = "하이브리드앱";
            Subject_2.text = "VR게임엔진프로그래밍";
            Subject_3.text = "VR게임개발프로젝트";
            Subject_4.text = "3D그래픽디자인";
            Subject_5.text = "앱개발창업";
            Subject_6.text = "VR영상편집";

            //하이브리드앱
            Subject_EX_1.text = "과목설명\n\n본 과목은 C 프로그래밍, JAVA프로그래밍, HTML5 등 학과에서 기초적으로 학습하는 프로그래밍 언어들을 토대로 최신 기술들이 접목된 앱을 개발하는 기술을 학습하는 과정이다.";
            //VR게임엔진프로그래밍
            Subject_EX_2.text = "과목설명\n\nVR접목한 게임엔진을 이용하여 PC 및 웹, 모바일 버전의 게임을 개발하는 과정을 기초부터 설명해주는 과목으로 실제 런칭하며 개발에 필요한 요소들을 익힐 수 있다.";
            //VR게임개발프로젝트
            Subject_EX_3.text = "과목설명\n\n취업 역량을 강화할 수 있는 VR게임을 개발하는 프로젝트를 진행한다. VR 콘텐츠와 기존 콘텐츠의 다른 점을 학습하고 VR 콘텐츠의 특징을 살려 콘텐츠를 개발하는 과정이다.";
            //3D그래픽디자인
            Subject_EX_4.text = "과목설명\n\n3D가상공간의 구성방법과 3D캐릭터 구상, 구현 그리고 제작된 캐릭터 애니메이션 제작을 학습하며, 가상공간에서의 리소스 추가 및 활용하는 방법에 대해 학습한다.";
            //앱개발창업
            Subject_EX_5.text = "과목설명\n\n앱개발 계획과 개발 프로세스를 진행하여 완성된 산출물을 구글 등의 다양한 플랫폼으로 서비스 할 수 있는 능력을 함양하고 창업을 통한 서비스 영역을 학습하는 교육이다.";
            //VR영상편집
            Subject_EX_6.text = "과목설명\n\n가상현실에 특화된 360도 촬영영상을 콘텐츠로 제작하기 위해 본 교과목에서 촬영된 영상을 스스로, 편집 및 영상요소 추가, 마스터링 단계까지 콘텐츠제작에 적용가능한 영상으로 편집하는 방법을 학습한다.";
        }
        if (class_Num == 4) //2학년 2학기
        {
            Semester.text = "2학년 2학기";

            Subject_1.text = "반응형웹";
            Subject_2.text = "UI/UX디자인";
            Subject_3.text = "VR,AR콘텐츠제작";
            Subject_4.text = "포트폴리오";
            Subject_5.text = "캡스톤디자인";
            Subject_6.text = "현장실습";

            //반응형웹
            Subject_EX_1.text = "과목설명\n\nHTML5를 활용하여 PC와 모바일 환경에서 자유자제로 제공되는 웹 페이지 개발을 배우는 과정이다. CSS와 자바스크립트를 활용하여 웹 페이지를 개발하는 실무 교육을 배운다.";
            //UI/UX디자인
            Subject_EX_2.text = "과목설명\n\n안드로이드폰의 UI/UX를 학습하고 각 운영체제별 구성 컴포넌트와 프로토타이핑, 효과적인 실무 앱 디자인 프로세스를 배운다.";
            //VR,AR콘텐츠제작
            Subject_EX_3.text = "과목설명\n\nVR공간구성 및 콘텐츠의 제작방법과 AR의 적용방법 및 활용분야에 대해 실습을 통해 그 차이점과 활용방안을 예제를 통해 학습하고 아이디어 도출, 실제 프로젝트에 적용하여 다양한 결과를 도출해낸다.";
            //포트폴리오
            Subject_EX_4.text = "과목설명\n\n지금까지 학생들이 배우고 익혔던 과정들을 활용하여 개인 포트폴리오를 개발하는 시간으로 모든 학기동안 개발한 프로젝트를 기반으로 다양한 형태의 서식을 개발함으로서 자신을 PR할 수 있다.";
            //캡스톤디자인
            Subject_EX_5.text = "과목설명\n\n1,2학년동안 배워온 지식을 통합하는 과정으로, 학과에서 배운 지식을 종합하여 학생들에게 주어진 아이디어를 실제로 앱으로 개발하여 현장적응형 인재양성 과정으로 활용될 수 있다.";
            //현장실습
            Subject_EX_6.text = "과목설명\n\n기업체의 산업현장에서 지금까지 배웠던 관련 기술을 익히고, 실습해봄으로써 하고가 과목의 효율성을 느끼고, 나아가 산업체에 바로 투입할 수 있는 인력을 양성하고자 개설된 학과목이다.";
        }
    }
}
