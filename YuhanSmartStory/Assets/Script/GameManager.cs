using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{ //�����ϱ�� �޽��ϱ⸦ ������ �ַ� �����ϱ� ���� ���� �Ŵ���
    public DataManager data;
    public ChangeState day;
    public PopUP_IMG popup_IMG;
    public SleepIMG sleepIMG;

    public GameObject Study_PopUp;
    public GameObject Week_Btn;


    public static bool ending_Play = false;

    public Point_estimation point_Num;
    
    public GameObject TextBox;
    public GameObject DayPoint;

    public static bool is_Perfect = false;
    public static bool is_Fail = false;
    public static bool is_W_Review = false;
    void Start()
    {

    }

    void Update()
    {//�ɷ�ġ �ٲ�´�� ������ ����
        DataSave.a = data.bar_physical.fillAmount;
        DataSave.b = data.bar_stress.fillAmount;
        DataSave.c = data.bar_volition.fillAmount;
        DataSave.d = data.bar_creative.fillAmount;
        DataSave.e = data.bar_thinking.fillAmount;
        DataSave.f = data.bar_knowledge.fillAmount;
    }

    public void Day_StudyBtn() //���� ����
    {
        data.bar_physical.fillAmount -= 0.1f;
        data.bar_stress.fillAmount += 0.1f;
        data.bar_creative.fillAmount += 0.06f;
        data.bar_thinking.fillAmount += 0.06f;
        data.bar_knowledge.fillAmount += 0.06f;
        DayPoint.SetActive(false);
        TextBox.SetActive(true);
        StudyPopUp.isblack = true;

    }
    public void Day_BreakBtn() //���� �޽�
    {
        data.bar_physical.fillAmount += 0.1f;
        data.bar_stress.fillAmount -= 0.1f;
        data.bar_creative.fillAmount -= 0.02f;
        data.bar_thinking.fillAmount -= 0.02f;
        data.bar_knowledge.fillAmount -= 0.02f;
        //�ִϸ��̼� �߰�
        day.Setting_Week();
    }

    public void Week_StudyBtn() //�ָ� ����
    {
        Study_PopUp.SetActive(true);
        Week_Btn.SetActive(false);
    }
   
    public void Week_BreakBtn() //�ָ� �޽�
    {//�޽��˾�â ����
        Week_Btn.SetActive(false);
        data.bar_creative.fillAmount -= 0.03f;
        data.bar_thinking.fillAmount -= 0.03f;
        data.bar_knowledge.fillAmount -= 0.03f;
        sleepIMG.Shape_Sleeping();
        if (DataSave.Week_Num<= 16)
        {
            Invoke("Delay_Setting_Day", 2f);
        }
    }

    public void Probability()//�����ϱ� ���� ���� Ȯ�� ������ �Լ�
    {
        int success = Random.Range(0, 100);
        
        if(success<=data.bar_volition.fillAmount*100+20) //����
        {
            Debug.Log("����");
            Preparation();
        }else if(success<=100- data.bar_volition.fillAmount*100 + 20) //����
        {
            Debug.Log("����");
            No_Study();
        }
    }

    public void Preparation() //�ָ� �����ϱ� �Լ�
    {
        Study_PopUp.SetActive(false);
        data.bar_creative.fillAmount += 0.02f;
        data.bar_thinking.fillAmount += 0.02f;
        data.bar_knowledge.fillAmount += 0.02f;
        popup_IMG.Shape_Study();
        is_Perfect = true;
    }

    public void Review()//�ָ� �����ϱ� �Լ�
    {
        Study_PopUp.SetActive(false);
        data.bar_creative.fillAmount += 0.01f;
        data.bar_thinking.fillAmount += 0.01f;
        data.bar_knowledge.fillAmount += 0.01f;
        popup_IMG.Shape_Study();
        is_W_Review = true;

    }

    public void No_Study() //�ָ� ���� �����Լ�
    {
        Study_PopUp.SetActive(false);
        data.bar_physical.fillAmount -= 0.1f;
        data.bar_stress.fillAmount += 0.1f;
        popup_IMG.Shape_Study();
        is_Fail = true;
    }
    
    public void Delay_Setting_Day()
    {
        sleepIMG.sp_cur.sprite = null;
        popup_IMG.Study_Text.SetActive(false);
        sleepIMG.Sleep_Text.text = "";
        DataSave.Week_Num += 1; //������
        Next_class(); //15������ ������ ���� �б�� �Ѿ.
        
    }

    public void Next_class() 
    {
        if (DataSave.Week_Num >= 16)
        {
            Subject_textManager.next_class_Num = true;
            //�������
            if(Subject_textManager.class_Num==1)
            {
                point_Num.estimation_1_1();
                Next_Class_Load();
                GameObject.Find("player_done").gameObject.transform.Find("Player").gameObject.SetActive(false);
            }
            if (Subject_textManager.class_Num == 2)
            {
                point_Num.estimation_1_2();
                Next_Class_Load();
                GameObject.Find("player_done").gameObject.transform.Find("Player").gameObject.SetActive(false);
            }
            if (Subject_textManager.class_Num == 3)
            {
                point_Num.estimation_2_1();
                Next_Class_Load();
                GameObject.Find("player_done").gameObject.transform.Find("Player").gameObject.SetActive(false);
            }
            if (Subject_textManager.class_Num == 4)
            {
                point_Num.estimation_2_2();
                Ending_Play();
                GameObject.Find("player_done").gameObject.transform.Find("Player").gameObject.SetActive(false);
                SceneManager.LoadScene("Ending");
                //�������� ���±�
            }
            DataSave.Week_Num = 1;
            CharacterManager.nature = 9;
        }else
        {
            day.Setting_Day();
        }
    }

    public void Next_Class_Load()
    {
        SceneManager.LoadScene("SubjectScene_1");
    }

    public void Ending_Play()
    {
       if(DataSave.F>=1)
        {
            EndingManager.isF = true;
        }
        else
        {
            if (DataSave.A_Plus >= 6) EndingManager.isExcellent = true; //����� ����
            else if (DataSave.B_Plus + DataSave.A + DataSave.A_Plus >= 5) EndingManager.iseasy = true; //������ ����
            else if (DataSave.D >= 4) EndingManager.ispullUp = true; //������ �ΰ���
            else
            {
                EndingManager.iscommon = true; //����� ����
            }
            
            
        }
    }
    
}
