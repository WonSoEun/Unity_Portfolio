using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SleepIMG : MonoBehaviour
{
    public Sprite[] player_currently_shape;
    public SpriteRenderer sp_cur;

    public bool is_sleep_Week = false; //zz 애니메이션 발동
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
                sp_cur.sprite = player_currently_shape[0]; //남자신입생 sprite 설정
                is_sleep_Week = true;
                Sleep_Text.text = "역시 잠이 최고지..zz";
            }
            if (CharacterManager.NO == "O")
            {
                sp_cur.sprite = player_currently_shape[1]; //남자복학생 sprite 설정
                is_sleep_Week = true;
                Sleep_Text.text = "역시 잠이 최고지..zz";
            }
        }
        if (CharacterManager.MW == "W")
        {
            if (CharacterManager.NO == "N")
            {
                sp_cur.sprite = player_currently_shape[2]; //여자신입생 sprite 설정
                is_sleep_Week = true;
                Sleep_Text.text = "역시 잠이 최고지..zz";
            }
            if (CharacterManager.NO == "O")
            {
                sp_cur.sprite = player_currently_shape[3]; //여자복학생 sprite 설정
                is_sleep_Week = true;
                Sleep_Text.text = "역시 잠이 최고지..zz";
            }
        }
    }

    public void NullSprite()
    {
        sp_cur.sprite = null;
        Sleep_Text.text = "";

    }
}
