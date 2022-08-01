using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUP_IMG : MonoBehaviour
{
    Animator ani_study;

   // public Sprite[] player_currently_shape;
    public SpriteRenderer sp_cur;

    public Text Sleep_Text;
    public GameObject Study_Text;
    public GameObject TextBox;
    public StudyPopUp studypop;

   // public bool is_sleep_Week = false; //zz �ִϸ��̼� �ߵ�
    public static bool c_Study = false;
    public static bool A_Study = false;
    public static bool vr_Study = false;
    public static bool design_Study = false;
    public static bool Argori_Study = false;
    public static bool team_Study = false;

    void Start()
    {
        sp_cur = GetComponent<SpriteRenderer>();
        ani_study = GetComponent<Animator>();
    }

    void Update()
    {
        
    }
  /*  public void Shape_Sleeping()
    {
        if (CharacterManager.MW == "M")
        {
            if (CharacterManager.NO == "N")
            {
                sp_cur.sprite = player_currently_shape[0]; //���ڽ��Ի� sprite ����
                is_sleep_Week = true;
                Sleep_Text.text = "���� ���� �ְ���..zz";
            }
            if (CharacterManager.NO == "O")            {
                sp_cur.sprite = player_currently_shape[1]; //���ں��л� sprite ����
                is_sleep_Week = true;
                Sleep_Text.text = "���� ���� �ְ���..zz";
            }
        }
        if (CharacterManager.MW == "W")
        {
            if (CharacterManager.NO == "N")
            {
                sp_cur.sprite = player_currently_shape[2]; //���ڽ��Ի� sprite ����
                is_sleep_Week = true;
                Sleep_Text.text = "���� ���� �ְ���..zz";
            }
            if (CharacterManager.NO == "O")
            {
                sp_cur.sprite = player_currently_shape[3]; //���ں��л� sprite ����
                is_sleep_Week = true;
                Sleep_Text.text = "���� ���� �ְ���..zz";
            }
        }
    }*/
    public void Shape_Study()
    {
        if(vr_Study)
        {
            ani_study.SetTrigger("vr_study");
            Invoke("null_aniStudy",3f);
        }
        else if(design_Study)
        {
            ani_study.SetTrigger("art_study");
            Invoke("null_aniStudy", 3f);
        }
        else if(team_Study)
        {
            ani_study.SetTrigger("project_study");
            Invoke("null_aniStudy", 3f);
        }
        else if(Argori_Study)
        {
            ani_study.SetTrigger("algo_study");
            Invoke("null_aniStudy", 3f);
        }
        else if(A_Study)
        {
            TextBox.SetActive(true);
            StudyPopUp.isblack = true;
        }
        else if(c_Study)
        {
            TextBox.SetActive(true);
            StudyPopUp.isblack = true;
        }
    }

    void null_aniStudy()
    {
        ani_study.SetTrigger("null");
        studypop.result();
    }
    /*public void NullSprite()
    {
        sp_cur.sprite = null;
        Sleep_Text.text = "";
    }*/
}
