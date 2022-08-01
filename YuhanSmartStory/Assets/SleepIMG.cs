using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SleepIMG : MonoBehaviour
{
    public Sprite[] player_currently_shape;
    public SpriteRenderer sp_cur;

    public bool is_sleep_Week = false; //zz �ִϸ��̼� �ߵ�
    public Text Sleep_Text;
    void Start()
    {

    }

    void Update()
    {

    }

    public void Shape_Sleeping()
    {
        if (CharacterManager.MW == "M")
        {
            if (CharacterManager.NO == "N")
            {
                sp_cur.sprite = player_currently_shape[0]; //���ڽ��Ի� sprite ����
                is_sleep_Week = true;
                Sleep_Text.text = "���� ���� �ְ���..zz";
            }
            if (CharacterManager.NO == "O")
            {
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
    }

    public void NullSprite()
    {
        sp_cur.sprite = null;
        Sleep_Text.text = "";

    }
}
