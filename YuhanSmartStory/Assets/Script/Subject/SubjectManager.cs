using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SubjectManager : MonoBehaviour
{
    public GameObject First_CheckBox; //체크모양을 통해 선택이 되었는가를 표시(SetActive)
    public GameObject Second_CheckBox;
    public GameObject Third_CheckBox;
    public GameObject Fourth_CheckBox;
    public GameObject Fiveth_CheckBox;
    public GameObject Sixth_CheckBox;

    public GameObject First_SubjectExplain; //과목설명 상자(SetActive)
    public GameObject Second_SubjectExplain;
    public GameObject Third_SubjectExplain;
    public GameObject Fourth_SubjectExplain;
    public GameObject Fiveth_SubjectExplain;
    public GameObject Sixth_SubjectExplain;

    public Subject_Data Sub_data;
    public Point_estimation point_Num;
    void Start()
    {
        
    }
    public void NextBtn(string SceneName)
    {
        if (Subject_check.CheckMax == 5)//과목 5개를 선택했다면..
        {  //INGame_Day로 씬 이동, 이동하는 순간의 player 위치설정, player 나타남.
            SceneManager.LoadScene(SceneName);
            DataSave.location = "Day";
            GameObject.Find("player_done").transform.Find("Player").gameObject.transform.position = new Vector3(0.95f, 1.37f, 0f);
            GameObject.Find("player_done").transform.Find("Player").gameObject.SetActive(true);
            
        }
    }

  
    void Update()
    {
       
        if(Subject_check.CheckMax != 6)
        { //5과목을 아직 선택하지 않았다면, 선택할 수 있게 함.(짝수,홀수에 따라 체크 활성화 유무)
            if (Subject_check.First_click_Num % 2 == 0 || Subject_check.First_click_Num == 0)
            {
                First_CheckBox.SetActive(false);
                Sub_data.Subject_1_Set();
            }
            else
            {
                First_CheckBox.SetActive(true);
                Sub_data.Subject_1();
            }
            if (Subject_check.Second_click_Num % 2 == 0 || Subject_check.Second_click_Num == 0)
            {
                Second_CheckBox.SetActive(false); 
                Sub_data.Subject_2_Set();
            }
            else
            {
                Second_CheckBox.SetActive(true);
                Sub_data.Subject_2();
            }
            if (Subject_check.Third_click_Num % 2 == 0 || Subject_check.Third_click_Num == 0)
            {
                Third_CheckBox.SetActive(false);
                Sub_data.Subject_3_Set();
            }
            else
            {
                Third_CheckBox.SetActive(true);
                Sub_data.Subject_3();
            }
            if (Subject_check.Fourth_click_Num % 2 == 0 || Subject_check.Fourth_click_Num == 0)
            {
                Fourth_CheckBox.SetActive(false);
                Sub_data.Subject_4_Set();
            }
            else
            {
                Fourth_CheckBox.SetActive(true);
                Sub_data.Subject_4();
            }
            if (Subject_check.Fiveth_click_Num % 2 == 0 || Subject_check.Fiveth_click_Num == 0)
            {
                Fiveth_CheckBox.SetActive(false);
                Sub_data.Subject_5_Set();
            }
            else
            {
                Fiveth_CheckBox.SetActive(true);
                Sub_data.Subject_5();
            }
            if (Subject_check.Sixth_click_Num % 2 == 0 || Subject_check.Sixth_click_Num == 0)
            {
                Sixth_CheckBox.SetActive(false);
                Sub_data.Subject_6_Set();
            }
            else
            {
                Sixth_CheckBox.SetActive(true);
                Sub_data.Subject_6();
            }
        }

        // 과목설명창 선택 (짝수,홀수에 따라 체크 활성화 유무)
        if (Subject_check.First_Subject_Num % 2==0)
        {
            First_SubjectExplain.SetActive(false);
        }
        else
        {
            First_SubjectExplain.SetActive(true);
        }
        if (Subject_check.Second_Subject_Num % 2 == 0)
        {
            Second_SubjectExplain.SetActive(false);
        }
        else
        {
            Second_SubjectExplain.SetActive(true);
        }
        if (Subject_check.Third_Subject_Num % 2 == 0)
        {
            Third_SubjectExplain.SetActive(false);
        }
        else
        {
            Third_SubjectExplain.SetActive(true);
        }
        if (Subject_check.Fourth_Subject_Num % 2 == 0)
        {
            Fourth_SubjectExplain.SetActive(false);
        }
        else
        {
            Fourth_SubjectExplain.SetActive(true);
        }
        if (Subject_check.Fiveth_Subject_Num % 2 == 0)
        {
            Fiveth_SubjectExplain.SetActive(false);
        }
        else
        {
            Fiveth_SubjectExplain.SetActive(true);
        }
        if (Subject_check.Sixth_Subject_Num % 2 == 0)
        {
            Sixth_SubjectExplain.SetActive(false);
        }
        else
        {
            Sixth_SubjectExplain.SetActive(true);
        }

        Sub_data.Coordinize();
        if (Subject_textManager.next_class_Num)
            Subject_check_Set();
    }

    

  
    
    public void Subject_check_Set() //체크 초기화
    {
        First_CheckBox.SetActive(false);
        First_SubjectExplain.SetActive(false);
        Second_CheckBox.SetActive(false);
        Second_SubjectExplain.SetActive(false);
        Third_CheckBox.SetActive(false);
        Third_SubjectExplain.SetActive(false);
        Fourth_CheckBox.SetActive(false);
        Fourth_SubjectExplain.SetActive(false);
        Fiveth_CheckBox.SetActive(false);
        Fiveth_SubjectExplain.SetActive(false);
        Sixth_CheckBox.SetActive(false);
        Sixth_SubjectExplain.SetActive(false);

        Subject_check.First_click_Num = 0;
        Subject_check.First_Subject_Num = 0;
        Subject_check.Second_click_Num = 0;
        Subject_check.Second_Subject_Num = 0;
        Subject_check.Third_click_Num = 0;
        Subject_check.Third_Subject_Num = 0;
        Subject_check.Fourth_click_Num = 0;
        Subject_check.Fourth_Subject_Num = 0;
        Subject_check.Fiveth_click_Num = 0;
        Subject_check.Fiveth_Subject_Num = 0;
        Subject_check.Sixth_click_Num = 0;
        Subject_check.Sixth_Subject_Num = 0;

        Subject_check.CheckMax = 0;
    }
}
