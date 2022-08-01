using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingCharacter : MonoBehaviour
{
    public Sprite[] Ending_Player_shape; //엔딩에서의 캐릭터 이미지 변경하는 배열
    
    SpriteRenderer Ending_sp;


    void Start()
    {
        Ending_sp = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if(EndingManager.isExcellent) //우수한 졸업 
        {
            if (CharacterManager.MW == "M")
            {
                if (CharacterManager.NO == "N")
                {
                    Ending_sp.sprite = Ending_Player_shape[0];  //우수한 남자신입생 모습
                    Debug.Log("우수한 남자신입생");
                }
                if (CharacterManager.NO == "O")
                {
                    Ending_sp.sprite = Ending_Player_shape[1];//우수한 남자복학생 모습
                    Debug.Log("우수한 남자복학생");
                }
            }
            if (CharacterManager.MW == "W")
            {
                if (CharacterManager.NO == "N")
                {
                    Ending_sp.sprite = Ending_Player_shape[2];//우수한 여자신입생 모습
                    Debug.Log("우수한 여자신입생");
                }
                if (CharacterManager.NO == "O")
                {
                    Ending_sp.sprite = Ending_Player_shape[3];//우수한 여자복학생 모습
                    Debug.Log("우수한 여자복학생");
                }
            }
        }
        
        if(EndingManager.iseasy) //무난한 졸업
        {
            if (CharacterManager.MW == "M")
            {
                if (CharacterManager.NO == "N")
                {
                    Ending_sp.sprite = Ending_Player_shape[4];  //무난한 남자신입생 모습
                    Debug.Log("무난한 남자신입생");
                }
                if (CharacterManager.NO == "O")
                {
                    Ending_sp.sprite = Ending_Player_shape[5];//무난한 남자복학생 모습
                    Debug.Log("무난한 남자복학생");
                }
            }
            if (CharacterManager.MW == "W")
            {
                if (CharacterManager.NO == "N")
                {
                    Ending_sp.sprite = Ending_Player_shape[6];//무난한 여자신입생 모습
                    Debug.Log("무난한 여자신입생");
                }
                if (CharacterManager.NO == "O")
                {
                    Ending_sp.sprite = Ending_Player_shape[7];//무난한 여자신입생 모습
                    Debug.Log("무난한 여자복학생");
                }
            }
        }
        

        if (EndingManager.iscommon)//평범한 졸업
        {
            Ending_sp.sprite = null;
            Debug.Log("평범한 졸업생");
        }

        if(EndingManager.ispullUp)
        {
            gameObject.transform.position = new Vector3(0, 0.6f, -1);
            if (CharacterManager.MW == "M")
            {
                if (CharacterManager.NO == "N")
                {
                    Ending_sp.sprite = Ending_Player_shape[8];  //간신히턱걸이 남자신입생 모습
                    Debug.Log("간신히턱걸이 남자신입생");
                }
                if (CharacterManager.NO == "O")
                {
                    Ending_sp.sprite = Ending_Player_shape[9];//간신히턱걸이 남자복학생 모습
                    Debug.Log("간신히턱걸이 남자복학생");
                }
            }
            if (CharacterManager.MW == "W")
            {
                if (CharacterManager.NO == "N")
                {
                    Ending_sp.sprite = Ending_Player_shape[10];//간신히턱걸이 여자신입생 모습
                    Debug.Log("간신히턱걸이 여자신입생");
                }
                if (CharacterManager.NO == "O")
                {
                    Ending_sp.sprite = Ending_Player_shape[11];//간신히턱걸이 여자복학생 모습
                    Debug.Log("간신히턱걸이 여자복학생");
                }
            }
        }
        
        if(EndingManager.isF)
        {
            gameObject.transform.position = new Vector3(-1.35f, 0, -1);
            if (CharacterManager.MW == "M")
            {
                if (CharacterManager.NO == "N")
                {
                    Ending_sp.sprite = Ending_Player_shape[12];  //F 남자신입생 모습
                    Debug.Log("F 남자신입생");
                }
                if (CharacterManager.NO == "O")
                {
                    Ending_sp.sprite = Ending_Player_shape[13];//F 남자복학생 모습
                    Debug.Log("F 남자복학생");
                }
            }
            if (CharacterManager.MW == "W")
            {
                if (CharacterManager.NO == "N")
                {
                    Ending_sp.sprite = Ending_Player_shape[14];//F 여자신입생 모습
                    Debug.Log("F 여자신입생");
                }
                if (CharacterManager.NO == "O")
                {
                    Ending_sp.sprite = Ending_Player_shape[15];//F 여자복학생 모습
                    Debug.Log("F 여자복학생");
                }
            }
        }

        

    }
}
