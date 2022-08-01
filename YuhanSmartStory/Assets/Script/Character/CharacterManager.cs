using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterManager : MonoBehaviour
{
    public GameObject StatPopup; //�ɷ�ġ 6�� �˾�â
    public GameObject OutfitPopup; // ���� 2�� �˾�â
    public GameObject check_F; // ���� ����(����) ��ư
    public GameObject check_M; //���� ����(����) ��ư
    public GameObject female; //���� ǥ�� (����)
    public GameObject male; //���� ǥ�� (����)

    public Text Stat_text;
    public Text Outfit_text;

    public GameObject Newstudent_F; //���ÿ� ���� ���ڽ��Ի� ���
    public GameObject Newstudent_M; //���ÿ� ���� ���ڽ��Ի� ���
    public GameObject Oldstudent_F; //���ÿ� ���� ���ں��л� ���
    public GameObject Oldstudent_M; //���ÿ� ���� ���ں��л� ���


    public bool is_stat = false; //�ɷ�ġ �����ߴٸ� true , ���ߴٸ� false
    public bool is_outfit = false; // ���� �����ߴٸ� true, ���ߴٸ� false
    public bool is_WM = false; // ���� �����ߴٸ� true, ���ߴٸ� false
    public static bool New = false;//���Ի��� �����ߴٸ� ���Ի� �ó�ý��� ��µ�
    public static bool Old = false;//���л��� �����ߴٸ� ���л� �ó�ý��� ��µ�.

    public static string MW; // player ���� ��������Ʈ�� �����ϱ� ���� char ���� (��,��)
    public static string NO; // player ���� ��������Ʈ�� �����ϱ� ���� char ����(����,����)
    public static int nature = 0; // �ɷ�ġ ������ ���� int����

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
        //�ɷ�ġ, ����, ���� ���� �Ϸ����� �� Scene�̵�(Synopsis ȭ������).player ��Ÿ��.
        if (is_stat && is_outfit && is_WM)
        {
            SceneManager.LoadScene(SceneName);
           // GameObject.Find("player_done").transform.Find("Player").gameObject.SetActive(true);
        }
    }


    public void PrevBtn(string SceneName) //�ڷΰ��� ��ư(Titleȭ������)
    {
        SceneManager.LoadScene(SceneName);
    }

    public void StatBtn() // �ɷ�ġ �˾�â ����
    {
        StatPopup.SetActive(true);
    }

    public void OutfitBtn() // ���� �˾�â ����
    {
        OutfitPopup.SetActive(true);
    }

    public void Outfit_1() //���Ի�
    { // �˾�â �ݰ�, ���� ���Ի� ��� �ٲٸ� �ش� ������ ����
        OutfitPopup.SetActive(false);
        Outfit_text.text = "���Ի�";
        Oldstudent_F.SetActive(false);
        Oldstudent_M.SetActive(false);
        Newstudent_F.SetActive(true);
        Newstudent_M.SetActive(true);
        is_outfit = true;
        New = true;
        NO = "N";
    }

    public void Outfit_2() //���л�
    { // �˾�â �ݰ�, ���� ���л� ������� �ٲٸ� �ش� ������ ����
        OutfitPopup.SetActive(false);
        Outfit_text.text = "���л�";
        Newstudent_F.SetActive(false);
        Newstudent_M.SetActive(false);
        Oldstudent_F.SetActive(true);
        Oldstudent_M.SetActive(true);
        is_outfit = true;
        Old = true;
        NO = "O";
    }

    public void Stat_1() //������
    {
        StatPopup.SetActive(false);
        Stat_text.text = "������";
        is_stat = true;
        nature = 1;
    }

    public void Stat_2() //��ſ�
    {
        StatPopup.SetActive(false);
        Stat_text.text = "��ſ�";
        is_stat = true;
        nature = 2;
    }

    public void Stat_3() //������
    {
        StatPopup.SetActive(false);
        Stat_text.text = "������";
        is_stat = true;
        nature = 3;
    }

    public void Stat_4() //�����
    {
        StatPopup.SetActive(false);
        Stat_text.text = "�����";
        is_stat = true;
        nature = 4;
    }

    public void Stat_5() //�Ҽ�����
    {
        StatPopup.SetActive(false);
        Stat_text.text = "�Ҽ�����";
        is_stat = true;
        nature = 5;
    }

    public void Stat_6() //�����ִ�
    {
        StatPopup.SetActive(false);
        Stat_text.text = "�����ִ�";
        is_stat = true;
        nature = 6;
    }

    public void Stat_7() //�����̾���
    {
        StatPopup.SetActive(false);
        Stat_text.text = "�����̾���";
        is_stat = true;
        nature = 7;
    }

    public void Student_FBtn() //���ڼ��� ��ư
    {
        male.SetActive(false);
        female.SetActive(true);
        is_WM = true;
        MW = "W";
        
    }

    public void Student_MBtn() //���ڼ��� ��ư
    {
        female.SetActive(false);
        male.SetActive(true);
        is_WM = true;
        MW = "M";
        
    }
}
