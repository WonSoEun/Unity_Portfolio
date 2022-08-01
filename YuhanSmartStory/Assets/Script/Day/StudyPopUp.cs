using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StudyPopUp : MonoBehaviour
{
    public TextAsset textfile_C; //c언어 계열
    public TextAsset textfile_A; //안드로이드 계열
    public TextMeshProUGUI Text;

    public ChangeState Day;
    public GameObject TextBox;

    public static bool isblack = false;
    public bool isTurn = false;

    public InGame_Ani ani_S; //애니메이션 스크립트
    void Start()
    {
        
    }

    IEnumerator TypingEffect()
    {
        if(!(PopUP_IMG.c_Study || PopUP_IMG.A_Study)) //평일 공부
        {
            int w = Random.Range(0, 2);
            Debug.Log(w);
            if (w == 0)
            {
                string tempTextline = textfile_C.text;
                for (int i = 0; i < tempTextline.Length; i++)
                {
                    Text.text += tempTextline[i];
                    yield return new WaitForSeconds(0.05f);
                }

                Invoke("Delay", 1.5f);
            }
            else
            {
                string tempTextline = textfile_A.text;
                for (int i = 0; i < tempTextline.Length; i++)
                {
                    Text.text += tempTextline[i];
                    yield return new WaitForSeconds(0.05f);
                }

                Invoke("Delay", 1.5f);
            }
        }
        if(PopUP_IMG.A_Study)
        {
            string tempTextline = textfile_A.text;
            for (int i = 0; i < tempTextline.Length; i++)
            {
                Text.text += tempTextline[i];
                yield return new WaitForSeconds(0.05f);
            }

            Invoke("Delay", 1.5f);
        }
        if(PopUP_IMG.c_Study)
        {
            string tempTextline = textfile_C.text;
            for (int i = 0; i < tempTextline.Length; i++)
            {
                Text.text += tempTextline[i];
                yield return new WaitForSeconds(0.05f);
            }

            Invoke("Delay", 1.5f);
        }
        
        
    }

    void Update()
    {
        if (isblack)
        {
            StartCoroutine("TypingEffect");
            isblack = false;
        }
    }

    void Delay()
    {
        StopCoroutine("TypingEffect");
        Text.text = "";
        TextBox.SetActive(false);
        result();
    }

    public void result()
    {
        Debug.Log("result");
        if (GameManager.is_Perfect || GameManager.is_Fail)
        {
            ani_S.PF_Ani();
        }
        else if (GameManager.is_W_Review)
        {
            DataSave.Week_Num += 1;
            Day.Setting_Day();
            GameManager.is_W_Review = false;
        }
        else
        {
            Day.Setting_Week();
        }
    }
}
