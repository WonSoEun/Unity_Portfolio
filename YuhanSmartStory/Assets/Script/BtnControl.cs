using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnControl : MonoBehaviour
{
    public GameObject home_popUp;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void HomeBtn() //홈버튼
    {
        home_popUp.SetActive(true);
    }

    
    public void AgainBtn(string againScene) //홈버튼 다시하기
    {
        //변수 초기화 (FadeIn 스크립트에서도 수정)
        FadeInOut_Text.num = 0; //시놉시스 변수 초기화
        Subject_check.First_click_Num = 0; //과목설정 변수 초기화
        Subject_check.Second_click_Num = 0;
        Subject_check.Third_click_Num = 0;
        Subject_check.Fourth_click_Num = 0;
        Subject_check.Fiveth_click_Num = 0;
        Subject_check.Sixth_click_Num = 0;

        Subject_check.First_Subject_Num = 0;
        Subject_check.Second_Subject_Num = 0;
        Subject_check.Third_Subject_Num = 0;
        Subject_check.Fourth_Subject_Num = 0;
        Subject_check.Fiveth_Subject_Num = 0;
        Subject_check.Sixth_Subject_Num = 0;
        Subject_check.CheckMax = 0;

        CharacterManager.New = false; //캐릭터 별 시놉시스 텍스트 초기화
        CharacterManager.Old = false;
        CharacterManager.nature = 0;

        SceneManager.LoadScene(againScene);
        //플레이어 숨겨야함.
    }

    public void BackBtn() //뒤로가기버튼
    {
        home_popUp.SetActive(false);
    }
}
