using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point_estimation : MonoBehaviour
{
    // ��������� ���� ��ũ��Ʈ
    

    public Subject_Data sub_data;

    void Start()
    {
        DataSave.sum = 0;
    }

    void Update()
    {
        DataSave.sum = DataSave.sum + DataSave.Num;
    }

      

    public void estimation_Point_Num() //�� ���� ��� ������ �޾Ҵ��� ����ϱ� ����.(��������)
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

    public void estimation_1_1() //1�г� 1�б� ���� ���
    {
        if (sub_data.Subject_Text_1.text == "VR���Ӿ������ɷ�" || sub_data.Subject_Text_2.text == "VR���Ӿ������ɷ�" ||
            sub_data.Subject_Text_3.text == "VR���Ӿ������ɷ�" || sub_data.Subject_Text_4.text == "VR���Ӿ������ɷ�" ||
            sub_data.Subject_Text_5.text == "VR���Ӿ������ɷ�")//VR���Ӿ������ɷ�
        {
            DataSave.Num = ((DataSave.d * 100) + (DataSave.f * 100)) / 2;
            estimation_Point_Num();
        }
        if(sub_data.Subject_Text_1.text == "C ���α׷���" || sub_data.Subject_Text_2.text == "C ���α׷���" ||
            sub_data.Subject_Text_3.text == "C ���α׷���" || sub_data.Subject_Text_4.text == "C ���α׷���" ||
            sub_data.Subject_Text_5.text == "C ���α׷���")//C���α׷���
        {
            DataSave.Num = ((DataSave.e * 100) + (DataSave.f * 100)) / 2;
            estimation_Point_Num();
        }
        if(sub_data.Subject_Text_1.text == "���̼� ���α׷���" || sub_data.Subject_Text_2.text == "���̼� ���α׷���" ||
            sub_data.Subject_Text_3.text == "���̼� ���α׷���" || sub_data.Subject_Text_4.text == "���̼� ���α׷���" ||
            sub_data.Subject_Text_5.text == "���̼� ���α׷���")//���̼� ���α׷���
        {
            DataSave.Num = ((DataSave.d * 100) + (DataSave.f * 100)) / 2;
            estimation_Point_Num();
        }
        if(sub_data.Subject_Text_1.text == "JAVA ����" || sub_data.Subject_Text_2.text == "JAVA ����" ||
            sub_data.Subject_Text_3.text == "JAVA ����" || sub_data.Subject_Text_4.text == "JAVA ����" ||
            sub_data.Subject_Text_5.text == "JAVA ����")//Java����
        {
            DataSave.Num = ((DataSave.e * 100) + (DataSave.f * 100)) / 2;
            estimation_Point_Num();
        }
        if(sub_data.Subject_Text_1.text == "�ȵ���̵� ����" || sub_data.Subject_Text_2.text == "�ȵ���̵� ����" ||
            sub_data.Subject_Text_3.text == "�ȵ���̵� ����" || sub_data.Subject_Text_4.text == "�ȵ���̵� ����" ||
            sub_data.Subject_Text_5.text == "�ȵ���̵� ����")//�ȵ���̵����
        {
            DataSave.Num = DataSave.f * 100;
            estimation_Point_Num();
        }
        if(sub_data.Subject_Text_1.text == "��ũ��ġ ���α׷���" || sub_data.Subject_Text_2.text == "��ũ��ġ ���α׷���" ||
            sub_data.Subject_Text_3.text == "��ũ��ġ ���α׷���" || sub_data.Subject_Text_4.text == "��ũ��ġ ���α׷���" ||
            sub_data.Subject_Text_5.text == "��ũ��ġ ���α׷���")//��ũ��ġ ���α׷���
        {
            DataSave.Num = DataSave.f * 100;
            estimation_Point_Num();
        }
    }
    public void estimation_1_2() //1�г� 2�б� ���� ���
    {
        if (sub_data.Subject_Text_1.text == "HTML5" || sub_data.Subject_Text_2.text == "HTML5" ||
            sub_data.Subject_Text_3.text == "HTML5" || sub_data.Subject_Text_4.text == "HTML5" ||
            sub_data.Subject_Text_5.text == "HTML5")//HTML5
        {
            DataSave.Num = ((DataSave.d * 100) + (DataSave.f * 100)) / 2;
            estimation_Point_Num();
        }
        if (sub_data.Subject_Text_1.text == "�ȵ���̵� ���α׷���" || sub_data.Subject_Text_2.text == "�ȵ���̵� ���α׷���" ||
            sub_data.Subject_Text_3.text == "�ȵ���̵� ���α׷���" || sub_data.Subject_Text_4.text == "�ȵ���̵� ���α׷���" ||
            sub_data.Subject_Text_5.text == "�ȵ���̵� ���α׷���")//�ȵ���̵� ���α׷���
        {
            DataSave.Num = DataSave.f * 100;
            estimation_Point_Num();
        }
        if (sub_data.Subject_Text_1.text == "���� �˰���" || sub_data.Subject_Text_2.text == "���� �˰���" ||
            sub_data.Subject_Text_3.text == "���� �˰���" || sub_data.Subject_Text_4.text == "���� �˰���" ||
            sub_data.Subject_Text_5.text == "���� �˰���")//���� �˰���
        {
            DataSave.Num = ((DataSave.d * 100) + (DataSave.f * 100)) / 2;
            estimation_Point_Num();
        }
        if (sub_data.Subject_Text_1.text == "���ӿ�������" || sub_data.Subject_Text_2.text == "���ӿ�������" ||
            sub_data.Subject_Text_3.text == "���ӿ�������" || sub_data.Subject_Text_4.text == "���ӿ�������" ||
            sub_data.Subject_Text_5.text == "���ӿ�������")//���ӿ�������
        {
            DataSave.Num = DataSave.f * 100;
            estimation_Point_Num();
        }
        if (sub_data.Subject_Text_1.text == "��ǻ�ͱ׷��Ƚ�" || sub_data.Subject_Text_2.text == "��ǻ�ͱ׷��Ƚ�" ||
            sub_data.Subject_Text_3.text == "��ǻ�ͱ׷��Ƚ�" || sub_data.Subject_Text_4.text == "��ǻ�ͱ׷��Ƚ�" ||
            sub_data.Subject_Text_5.text == "��ǻ�ͱ׷��Ƚ�")//��ǻ�ͱ׷��Ƚ�
        {
            DataSave.Num = ((DataSave.e * 100) + (DataSave.f * 100)) / 2;
            estimation_Point_Num();
        }
        if (sub_data.Subject_Text_1.text == "�۰���" || sub_data.Subject_Text_2.text == "�۰���" ||
            sub_data.Subject_Text_3.text == "�۰���" || sub_data.Subject_Text_4.text == "�۰���" ||
            sub_data.Subject_Text_5.text == "�۰���")//�۰���
        {
            DataSave.Num = ((DataSave.e * 100) + (DataSave.f * 100)) / 2;
            estimation_Point_Num();
        }
    }
    public void estimation_2_1() //2�г� 1�б� ���� ���
    {
        if (sub_data.Subject_Text_1.text == "���̺긮���" || sub_data.Subject_Text_2.text == "���̺긮���" ||
            sub_data.Subject_Text_3.text == "���̺긮���" || sub_data.Subject_Text_4.text == "���̺긮���" ||
            sub_data.Subject_Text_5.text == "���̺긮���")//���̺긮���
        {
            DataSave.Num = ((DataSave.d * 100) + (DataSave.f * 100)) / 2;
            estimation_Point_Num();
        }
        if (sub_data.Subject_Text_1.text == "VR���ӿ������α׷���" || sub_data.Subject_Text_2.text == "VR���ӿ������α׷���" ||
            sub_data.Subject_Text_3.text == "VR���ӿ������α׷���" || sub_data.Subject_Text_4.text == "VR���ӿ������α׷���" ||
            sub_data.Subject_Text_5.text == "VR���ӿ������α׷���")//VR���ӿ������α׷���
        {
            DataSave.Num = ((DataSave.e * 100) + (DataSave.f * 100)) / 2;
            estimation_Point_Num();
        }
        if (sub_data.Subject_Text_1.text == "VR���Ӱ���������Ʈ" || sub_data.Subject_Text_2.text == "VR���Ӱ���������Ʈ" ||
            sub_data.Subject_Text_3.text == "VR���Ӱ���������Ʈ" || sub_data.Subject_Text_4.text == "VR���Ӱ���������Ʈ" ||
            sub_data.Subject_Text_5.text == "VR���Ӱ���������Ʈ")//VR���Ӱ���������Ʈ
        {
            DataSave.Num = ((DataSave.e * 100) + (DataSave.f * 100)) / 2;
            estimation_Point_Num();
        }
        if (sub_data.Subject_Text_1.text == "3D�׷��ȵ�����" || sub_data.Subject_Text_2.text == "3D�׷��ȵ�����" ||
            sub_data.Subject_Text_3.text == "3D�׷��ȵ�����" || sub_data.Subject_Text_4.text == "3D�׷��ȵ�����" ||
            sub_data.Subject_Text_5.text == "3D�׷��ȵ�����")//3D�׷��ȵ�����
        {
            DataSave.Num = ((DataSave.d * 100) + (DataSave.f * 100)) / 2;
            estimation_Point_Num();
        }
        if (sub_data.Subject_Text_1.text == "�۰���â��" || sub_data.Subject_Text_2.text == "�۰���â��" ||
            sub_data.Subject_Text_3.text == "�۰���â��" || sub_data.Subject_Text_4.text == "�۰���â��" ||
            sub_data.Subject_Text_5.text == "�۰���â��")//�۰���â��
        {
            DataSave.Num = DataSave.f * 100;
            estimation_Point_Num();
        }
        if (sub_data.Subject_Text_1.text == "VR��������" || sub_data.Subject_Text_2.text == "VR��������" ||
            sub_data.Subject_Text_3.text == "VR��������" || sub_data.Subject_Text_4.text == "VR��������" ||
            sub_data.Subject_Text_5.text == "VR��������")//VR��������
        {
            DataSave.Num = DataSave.f * 100;
            estimation_Point_Num();
        }
    }

    public void estimation_2_2() //2�г� 2�б� ���� ���
    {
        if (sub_data.Subject_Text_1.text == "��������" || sub_data.Subject_Text_2.text == "��������" ||
            sub_data.Subject_Text_3.text == "��������" || sub_data.Subject_Text_4.text == "��������" ||
            sub_data.Subject_Text_5.text == "��������")//��������
        {
            DataSave.Num = ((DataSave.d * 100) + (DataSave.f * 100)) / 2;
            estimation_Point_Num();
        }
        if (sub_data.Subject_Text_1.text == "UI/UX������" || sub_data.Subject_Text_2.text == "UI/UX������" ||
            sub_data.Subject_Text_3.text == "UI/UX������" || sub_data.Subject_Text_4.text == "UI/UX������" ||
            sub_data.Subject_Text_5.text == "UI/UX������")//UI/UX������
        {
            DataSave.Num = ((DataSave.e * 100) + (DataSave.f * 100)) / 2;
            estimation_Point_Num();
        }
        if (sub_data.Subject_Text_1.text == "VR,AR����������" || sub_data.Subject_Text_2.text == "VR,AR����������" ||
            sub_data.Subject_Text_3.text == "VR,AR����������" || sub_data.Subject_Text_4.text == "VR,AR����������" ||
            sub_data.Subject_Text_5.text == "VR,AR����������")//VR,AR����������
        {
            DataSave.Num = DataSave.f * 100;
            estimation_Point_Num();
        }
        if (sub_data.Subject_Text_1.text == "��Ʈ������" || sub_data.Subject_Text_2.text == "��Ʈ������" ||
            sub_data.Subject_Text_3.text == "��Ʈ������" || sub_data.Subject_Text_4.text == "��Ʈ������" ||
            sub_data.Subject_Text_5.text == "��Ʈ������")//��Ʈ������
        {
            DataSave.Num = DataSave.f * 100;
            estimation_Point_Num();
        }
        if (sub_data.Subject_Text_1.text == "ĸ���������" || sub_data.Subject_Text_2.text == "ĸ���������" ||
            sub_data.Subject_Text_3.text == "ĸ���������" || sub_data.Subject_Text_4.text == "ĸ���������" ||
            sub_data.Subject_Text_5.text == "ĸ���������")//ĸ���������
        {
            DataSave.Num = ((DataSave.d * 100) + (DataSave.f * 100)) / 2;
            estimation_Point_Num();
        }
        if (sub_data.Subject_Text_1.text == "����ǽ�" || sub_data.Subject_Text_2.text == "����ǽ�" ||
            sub_data.Subject_Text_3.text == "����ǽ�" || sub_data.Subject_Text_4.text == "����ǽ�" ||
            sub_data.Subject_Text_5.text == "����ǽ�")//����ǽ�
        {
            DataSave.Num = ((DataSave.e * 100) + (DataSave.f * 100)) / 2;
            estimation_Point_Num();
        }
    }
}
