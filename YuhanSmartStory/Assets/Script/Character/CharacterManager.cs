using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterManager : MonoBehaviour
{
    public GameObject StatPopup; //능력치 6개 팝업창
    public GameObject OutfitPopup; // 외형 2개 팝업창
    public GameObject check_F; // 성별 선택(여자) 버튼
    public GameObject check_M; //성별 선택(남자) 버튼
    public GameObject female; //성별 표시 (여자)
    public GameObject male; //성별 표시 (남자)

    public Text Stat_text;
    public Text Outfit_text;

    public GameObject Newstudent_F; //선택에 따른 여자신입생 모습
    public GameObject Newstudent_M; //선택에 따른 남자신입생 모습
    public GameObject Oldstudent_F; //선택에 따른 여자복학생 모습
    public GameObject Oldstudent_M; //선택에 따른 남자복학생 모습


    public bool is_stat = false; //능력치 선택했다면 true , 안했다면 false
    public bool is_outfit = false; // 외형 선택했다면 true, 안했다면 false
    public bool is_WM = false; // 성별 선택했다면 true, 안했다면 false
    public static bool New = false;//신입생을 선택했다면 신입생 시놉시스가 출력됨
    public static bool Old = false;//복학생을 선택했다면 복학생 시놉시스가 출력됨.

    public static string MW; // player 외형 스프라이트을 설정하기 위한 char 변수 (남,여)
    public static string NO; // player 외형 스프라이트를 설저하기 위한 char 변수(신입,복학)
    public static int nature = 0; // 능력치 설정을 위한 int변수

    public AudioClip clickSound;

    void Start()
    {
        StatPopup.SetActive(false);
        OutfitPopup.SetActive(false);
        Stat_text.text = "";
        Outfit_text.text = "";
        Newstudent_F.SetActive(true);
        Newstudent_M.SetActive(true);
        is_stat = false;
        is_outfit = false;
        is_WM = false;
    }

    void Update()
    {
        
    }

    public void NextBtn(string SceneName)
    {
        //능력치, 외형, 성별 선택 완료했을 시 Scene이동(Synopsis 화면으로).player 나타남.
        if (is_stat && is_outfit && is_WM)
        {
            SceneManager.LoadScene(SceneName);
           // GameObject.Find("player_done").transform.Find("Player").gameObject.SetActive(true);
        }
    }


    public void PrevBtn(string SceneName) //뒤로가기 버튼(Title화면으로)
    {
        SceneManager.LoadScene(SceneName);
    }

    public void StatBtn() // 능력치 팝업창 띄우기
    {
        StatPopup.SetActive(true);
    }

    public void OutfitBtn() // 외형 팝업창 띄우기
    {
        OutfitPopup.SetActive(true);
    }

    public void Outfit_1() //신입생
    { // 팝업창 닫고, 남여 신입생 모습 바꾸며 해당 변수들 설정
        OutfitPopup.SetActive(false);
        Outfit_text.text = "신입생";
        Oldstudent_F.SetActive(false);
        Oldstudent_M.SetActive(false);
        Newstudent_F.SetActive(true);
        Newstudent_M.SetActive(true);
        is_outfit = true;
        New = true;
        NO = "N";
    }

    public void Outfit_2() //복학생
    { // 팝업창 닫고, 남여 복학생 모습으로 바꾸며 해당 변수들 설정
        OutfitPopup.SetActive(false);
        Outfit_text.text = "복학생";
        Newstudent_F.SetActive(false);
        Newstudent_M.SetActive(false);
        Oldstudent_F.SetActive(true);
        Oldstudent_M.SetActive(true);
        is_outfit = true;
        Old = true;
        NO = "O";
    }

    public void Stat_1() //성실한
    {
        StatPopup.SetActive(false);
        Stat_text.text = "성실한";
        is_stat = true;
        nature = 1;
    }

    public void Stat_2() //즐거운
    {
        StatPopup.SetActive(false);
        Stat_text.text = "즐거운";
        is_stat = true;
        nature = 2;
    }

    public void Stat_3() //적당한
    {
        StatPopup.SetActive(false);
        Stat_text.text = "적당한";
        is_stat = true;
        nature = 3;
    }

    public void Stat_4() //우수한
    {
        StatPopup.SetActive(false);
        Stat_text.text = "우수한";
        is_stat = true;
        nature = 4;
    }

    public void Stat_5() //불성실한
    {
        StatPopup.SetActive(false);
        Stat_text.text = "불성실한";
        is_stat = true;
        nature = 5;
    }

    public void Stat_6() //끈기있는
    {
        StatPopup.SetActive(false);
        Stat_text.text = "끈기있는";
        is_stat = true;
        nature = 6;
    }

    public void Stat_7() //생각이없는
    {
        StatPopup.SetActive(false);
        Stat_text.text = "생각이없는";
        is_stat = true;
        nature = 7;
    }

    public void Student_FBtn() //여자선택 버튼
    {
        male.SetActive(false);
        female.SetActive(true);
        is_WM = true;
        MW = "W";
        
    }

    public void Student_MBtn() //남자선택 버튼
    {
        female.SetActive(false);
        male.SetActive(true);
        is_WM = true;
        MW = "M";
        
    }
}
