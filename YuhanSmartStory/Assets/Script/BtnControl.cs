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

    public void HomeBtn() //Ȩ��ư
    {
        home_popUp.SetActive(true);
    }

    
    public void AgainBtn(string againScene) //Ȩ��ư �ٽ��ϱ�
    {
        //���� �ʱ�ȭ (FadeIn ��ũ��Ʈ������ ����)
        FadeInOut_Text.num = 0; //�ó�ý� ���� �ʱ�ȭ
        Subject_check.First_click_Num = 0; //������ ���� �ʱ�ȭ
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

        CharacterManager.New = false; //ĳ���� �� �ó�ý� �ؽ�Ʈ �ʱ�ȭ
        CharacterManager.Old = false;
        CharacterManager.nature = 0;

        SceneManager.LoadScene(againScene);
        //�÷��̾� ���ܾ���.
    }

    public void BackBtn() //�ڷΰ����ư
    {
        home_popUp.SetActive(false);
    }
}
