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
            Debug.Log("d��������");
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
            Subject_Text_1.text = "VR���Ӿ������ɷ�";
            DataSave.subject1 = "VR���Ӿ������ɷ�";
        }
        if (Subject_textManager.class_Num == 2)
        {
            Subject_Text_1.text = "HTML5";
            DataSave.subject1 = "HTML5";
        }
        if (Subject_textManager.class_Num == 3)
        {
            Subject_Text_1.text = "���̺긮���";
            DataSave.subject1 = "���̺긮���";
        }
        if (Subject_textManager.class_Num == 4)
        {
            Subject_Text_1.text = "��������";
            DataSave.subject1 = "��������";
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
            Subject_Text_2.text = "C ���α׷���";
            DataSave.subject2 = "C ���α׷���";
        }
        if (Subject_textManager.class_Num == 2)
        {
            Subject_Text_2.text = "�ȵ���̵� ���α׷���";
            DataSave.subject2 = "�ȵ���̵� ���α׷���";
        }
        if (Subject_textManager.class_Num == 3)
        {
            Subject_Text_2.text = "VR���ӿ������α׷���";
            DataSave.subject2 = "VR���ӿ������α׷���";
        }
        if (Subject_textManager.class_Num == 4)
        {
            Subject_Text_2.text = "UI/UX������";
            DataSave.subject2 = "UI/UX������";
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
            Subject_Text_3.text = "���̼� ���α׷���";
            DataSave.subject3 = "���̼� ���α׷���";
        }
        if (Subject_textManager.class_Num == 2)
        {
            Subject_Text_3.text = "���� �˰���";
            DataSave.subject3 = "���� �˰���";
        }
        if (Subject_textManager.class_Num == 3)
        {
            Subject_Text_3.text = "VR���Ӱ���������Ʈ";
            DataSave.subject3 = "VR���Ӱ���������Ʈ";
        }
        if (Subject_textManager.class_Num == 4)
        {
            Subject_Text_3.text = "VR,AR����������";
            DataSave.subject3 = "VR,AR����������";
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
            Subject_Text_4.text = "JAVA ����";
            DataSave.subject4 = "JAVA ����";
        }
        if (Subject_textManager.class_Num == 2)
        {
            Subject_Text_4.text = "���ӿ�������";
            DataSave.subject4 = "���ӿ�������";
        }
        if (Subject_textManager.class_Num == 3)
        {
            Subject_Text_4.text = "3D�׷��ȵ�����";
            DataSave.subject4 = "3D�׷��ȵ�����";
        }
        if (Subject_textManager.class_Num == 4)
        {
            Subject_Text_4.text = "��Ʈ������";
            DataSave.subject4 = "��Ʈ������";
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
            Subject_Text_5.text = "�ȵ���̵� ����";
            DataSave.subject5 = "�ȵ���̵� ����";
        }
        if (Subject_textManager.class_Num == 2)
        {
            Subject_Text_5.text = "��ǻ�ͱ׷��Ƚ�";
            DataSave.subject5 = "��ǻ�ͱ׷��Ƚ�";
        }
        if (Subject_textManager.class_Num == 3)
        {
            Subject_Text_5.text = "�۰���â��";
            DataSave.subject5 = "�۰���â��";
        }
        if (Subject_textManager.class_Num == 4)
        {
            Subject_Text_5.text = "ĸ���������";
            DataSave.subject5 = "ĸ���������";
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
            Subject_Text_6.text = "��ũ��ġ ���α׷���";
            DataSave.subject6 = "��ũ��ġ ���α׷���";
        }
        if (Subject_textManager.class_Num == 2)
        {
            Subject_Text_6.text = "�۰���";
            DataSave.subject6 = "�۰���";
        }
        if (Subject_textManager.class_Num == 3)
        {
            Subject_Text_6.text = "VR��������";
            DataSave.subject6 = "VR��������";
        }
        if (Subject_textManager.class_Num == 4)
        {
            Subject_Text_6.text = "����ǽ�";
            DataSave.subject6 = "����ǽ�";
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
