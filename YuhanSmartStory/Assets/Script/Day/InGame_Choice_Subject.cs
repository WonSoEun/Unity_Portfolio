using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InGame_Choice_Subject : MonoBehaviour
{
    public Subject_Data sub_data;

    public Text Choice_Subject;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Choice_First()
    {
        if(sub_data.Subject_Text_1.text == "VR���Ӿ������ɷ�" || sub_data.Subject_Text_1.text == "C ���α׷���")
        {
            PopUP_IMG.c_Study = true;
        }else if(sub_data.Subject_Text_1.text == "HTML5" || sub_data.Subject_Text_1.text == "���̺긮���" ||
            sub_data.Subject_Text_1.text == "��������" || sub_data.Subject_Text_1.text == "�ȵ���̵� ���α׷���")
        {
            PopUP_IMG.A_Study = true;
        }else if(sub_data.Subject_Text_1.text == "VR���ӿ������α׷���")
        {
            PopUP_IMG.vr_Study = true;
        }else if(sub_data.Subject_Text_1.text == "UI/UX������")
        {
            PopUP_IMG.design_Study = true;
        }
    }
    public void Choice_Second()
    {
        if (sub_data.Subject_Text_2.text == "���̼� ���α׷���" || sub_data.Subject_Text_2.text == "C ���α׷���")
        {
            PopUP_IMG.c_Study = true;
        }
        else if (sub_data.Subject_Text_2.text == "�ȵ���̵� ���α׷���")
        {
            PopUP_IMG.A_Study = true;
        }
        else if (sub_data.Subject_Text_2.text == "VR���Ӱ���������Ʈ" || sub_data.Subject_Text_2.text == "VR,AR����������" ||
            sub_data.Subject_Text_2.text == "VR���ӿ������α׷���")
        {
            PopUP_IMG.vr_Study = true;
        }
        else if (sub_data.Subject_Text_2.text == "UI/UX������")
        {
            PopUP_IMG.design_Study = true;
        }else if (sub_data.Subject_Text_2.text == "���� �˰���")
        {
            PopUP_IMG.Argori_Study = true;
        }
    }
    public void Choice_Third()
    {
        if (sub_data.Subject_Text_3.text == "���̼� ���α׷���" || sub_data.Subject_Text_3.text == "JAVA ����")
        {
            PopUP_IMG.c_Study = true;
        }
        else if (sub_data.Subject_Text_3.text == "VR���Ӱ���������Ʈ" || sub_data.Subject_Text_3.text == "VR,AR����������" ||
            sub_data.Subject_Text_3.text == "���ӿ�������")
        {
            PopUP_IMG.vr_Study = true;
        }
        else if (sub_data.Subject_Text_3.text == "3D�׷��ȵ�����")
        {
            PopUP_IMG.design_Study = true;
        }
        else if (sub_data.Subject_Text_3.text == "���� �˰���")
        {
            PopUP_IMG.Argori_Study = true;
        }else if(sub_data.Subject_Text_3.text == "��Ʈ������")
        {
            PopUP_IMG.team_Study = true;
        }
    }
    public void Choice_Fourth()
    {
        if (sub_data.Subject_Text_4.text == "JAVA ����")
        {
            PopUP_IMG.c_Study = true;
        }
        else if (sub_data.Subject_Text_4.text == "���ӿ�������")
        {
            PopUP_IMG.vr_Study = true;
        }
        else if (sub_data.Subject_Text_4.text == "3D�׷��ȵ�����" || sub_data.Subject_Text_4.text == "��ǻ�ͱ׷��Ƚ�") 
        {
            PopUP_IMG.design_Study = true;
        }
        else if (sub_data.Subject_Text_4.text == "�ȵ���̵� ����")
        {
            PopUP_IMG.A_Study = true;
        }
        else if (sub_data.Subject_Text_4.text == "��Ʈ������" || sub_data.Subject_Text_4.text == "�۰���â��"
            || sub_data.Subject_Text_4.text == "ĸ���������")
        {
            PopUP_IMG.team_Study = true;
        }
    }
    public void Choice_Fiveth()
    {
        if (sub_data.Subject_Text_5.text == "��ũ��ġ ���α׷���")
        {
            PopUP_IMG.vr_Study = true;
        }
        else if (sub_data.Subject_Text_5.text == "VR��������" || sub_data.Subject_Text_5.text == "��ǻ�ͱ׷��Ƚ�")
        {
            PopUP_IMG.design_Study = true;
        }
        else if (sub_data.Subject_Text_5.text == "�ȵ���̵� ����")
        {
            PopUP_IMG.A_Study = true;
        }
        else if (sub_data.Subject_Text_5.text == "�۰���" || sub_data.Subject_Text_5.text == "�۰���â��"
            || sub_data.Subject_Text_5.text == "ĸ���������" || sub_data.Subject_Text_5.text == "����ǽ�")
        {
            PopUP_IMG.team_Study = true;
        }
    }


}
