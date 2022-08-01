using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SynopsisManager : MonoBehaviour
{
    public Sprite[] player_shape; // 캐릭터 이미지 변경하는 배열

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
                sp.sprite = player_shape[0]; //남자신입생 sprite 설정
                ani.SetTrigger("NewMen");

                if (FadeInOut_Text.num >= 5)
                {
                    ani.SetTrigger("Fire_NM");
                }
            }
            if (CharacterManager.NO == "O")
            {
                sp.sprite = player_shape[1]; //남자복학생 sprite 설정
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
                sp.sprite = player_shape[2]; //여자신입생 sprite 설정
                ani.SetTrigger("NewWomen");

                if (FadeInOut_Text.num >= 5)
                {
                    ani.SetTrigger("Fire_NF");
                }
                    
            }
            if (CharacterManager.NO == "O")
            {
                sp.sprite = player_shape[3]; //여자복학생 sprite 설정
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
