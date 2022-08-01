using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayManager : MonoBehaviour
{
    
    public Sprite[] con_sp;
    public Image condition;
    public Text condition_Text;
    public Text Semester_Text;

    public Image bar_1;
    public Image bar_2;
    public Image bar_3;
    public Image bar_4;
    public Image bar_5;
    public Image bar_6;

    public DataManager data;
    
    void Start()
    {
       
    }

    void Update()
    {
        
        //Player ����ǥ�� (���ǿ� ���� sprite�� text ǥ��)
        if (bar_1.fillAmount >= 0.9f && bar_2.fillAmount <= 0.1f)
        {
            condition.sprite = con_sp[0];
            condition_Text.text = "GOOD!";
        }
        if (0.75f <= bar_1.fillAmount && bar_1.fillAmount <= 0.9f &&
            0.1f <= bar_2.fillAmount && bar_2.fillAmount <= 0.25f)
        {
            condition.sprite = con_sp[1];
            condition_Text.text = "Normal~";
        }
        if (bar_1.fillAmount <= 0.25f && bar_2.fillAmount >= 0.75f)
        {
            condition.sprite = con_sp[2];
            condition_Text.text = "Worst!";
        }

        switch (CharacterManager.nature) // Nature���� ���� �ٸ� �ɷ�ġ ������ �Լ� ���
        {
            case 1:
                data.Faithful();
                CharacterManager.nature = 8; //1���� ������ �� �ְ��ϱ� ����. ������, ������Ʈ �Լ��� ���� �������� �ǹ���.
                break;
            case 2:
                data.Joyful();
                CharacterManager.nature = 8;
                break;
            case 3:
                data.Proper();
                CharacterManager.nature = 8;
                break;
            case 4:
                data.Excellent();
                CharacterManager.nature = 8;
                break;
            case 5:
                data.Dishonesty();
                CharacterManager.nature = 8;
                break;
            case 6:
                data.Glutinoues();
                CharacterManager.nature =  8;
                break;
            case 7:
                data.Unthinking();
                CharacterManager.nature = 8;
                break;

        }
        if(CharacterManager.nature==9) //�бⰡ ���ص� �ɷ�ġ�� �״�� 
        {
            bar_1.fillAmount = DataSave.a;
            bar_2.fillAmount = DataSave.b;
            bar_3.fillAmount = DataSave.c;
            bar_4.fillAmount = DataSave.d;
            bar_5.fillAmount = DataSave.e;
            bar_6.fillAmount = DataSave.f;
            CharacterManager.nature = 10;
        }


        if (Subject_textManager.class_Num == 1)
            Semester_Text.text = "1�г� 1�б� " + DataSave.Week_Num + "����";
        if (Subject_textManager.class_Num ==   2)
            Semester_Text.text = "1�г� 2�б� " + DataSave.Week_Num + "����";
        if (Subject_textManager.class_Num == 3)
            Semester_Text.text = "2�г� 1�б� " + DataSave.Week_Num + "����";
        if (Subject_textManager.class_Num == 4)
            Semester_Text.text = "2�г� 2�б� " + DataSave.Week_Num + "����";
    }

    
    
}
