using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SynopsisManager : MonoBehaviour
{
    public Sprite[] player_shape; // ĳ���� �̹��� �����ϴ� �迭

    SpriteRenderer sp;
    Animator ani;

    public DataManager data;
    public GameObject synop_sound_text;
    void Start()
    {
        sp = GetComponent<SpriteRenderer>();
        ani = GetComponent<Animator>();
    }

    void Update()
    {
        data = GameObject.Find("GameManager").GetComponent<DataManager>();
        if (CharacterManager.MW == "M")
        {
            if (CharacterManager.NO == "N")
            {
                sp.sprite = player_shape[0]; //���ڽ��Ի� sprite ����
                ani.SetTrigger("NewMen");

                if (FadeInOut_Text.num >= 5)
                {
                    ani.SetTrigger("Fire_NM");
                }
            }
            if (CharacterManager.NO == "O")
            {
                sp.sprite = player_shape[1]; //���ں��л� sprite ����
                ani.SetTrigger("OldMen");

                if (FadeInOut_Text.num >= 5)
                {
                    ani.SetTrigger("Fire_OM");
                }
            }
        }
        if (CharacterManager.MW == "W")
        {
            if (CharacterManager.NO == "N")
            {
                sp.sprite = player_shape[2]; //���ڽ��Ի� sprite ����
                ani.SetTrigger("NewWomen");

                if (FadeInOut_Text.num >= 5)
                {
                    ani.SetTrigger("Fire_NF");
                }
                    
            }
            if (CharacterManager.NO == "O")
            {
                sp.sprite = player_shape[3]; //���ں��л� sprite ����
                ani.SetTrigger("OldWomen");

                if (FadeInOut_Text.num >= 5)
                {
                    ani.SetTrigger("Fire_OF");
                }
            }
        }

        if (FadeInOut_Text.num >= 5)
            synop_sound_text.SetActive(false);
    }
}
