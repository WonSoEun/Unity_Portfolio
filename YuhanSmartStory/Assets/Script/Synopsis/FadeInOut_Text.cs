using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeInOut_Text : MonoBehaviour
{
    Text si;

    public static int num = 0;

    SpriteRenderer sr;
    

    void Awake()
    {
        si = GetComponent<Text>();
        StartCoroutine(FadeIn());
    }
    void Start()
    {
        
    }

    void Update()
    {
        if(CharacterManager.New)
        {
            switch (num)
            {
                case 0:
                    si.text = "갓 입학한 새내기, 난 20살이 되었다.";
                    break;
                case 1:
                    si.text = "모든 것이 새롭게 느껴지는 나이!!";
                    break;
                case 2:
                    si.text = "유한대 VR게임앱학과에서는\n 뭐를 배울까??";
                    break;
                case 3:
                    si.text = "나는 앞으로 어떤 학교생활을 보내지..?";
                    break;
                case 4:
                    si.text = "걱정 반.. 설렘 반..";
                    break;
                case 5:
                    si.text = "뭐든 못하겠어?!\n 지금의 나를 막을 사람은 없어!";
                    break;
                case 6:
                    si.text = "왜냐하면!!!!!!!!!!!";
                    break;
                case 7:
                    si.text = "나는 새내기, 20살이니까!!!!!!!!";
                    break;
                case 8:
                    si.text = "졸업까지 최선을 다해 뽜이팅해보자!!!!!!";
                    break;
            }
        }else if(CharacterManager.Old)
        {
            switch (num)
            {
                case 0:
                    si.text = "나는 복학생이다!!";
                    break;
                case 1:
                    si.text = "오랜만에 학교를 오게 되다니\n 감회가 새롭군..";
                    break;
                case 2:
                    si.text = "그치만, 전에 배운 내용이\n 하나도 기억이 나질 않는다..";
                    break;
                case 3:
                    si.text = "나는 앞으로 어떤 학교생활을 보내지..?";
                    break;
                case 4:
                    si.text = "걱정 반..이 아니라 걱정 만땅..";
                    break;
                case 5:
                    si.text = "큰일이야!..더욱 열심히 공부해야겠어!!";
                    break;
                case 6:
                    si.text = "할수있다, 하면된다, 해보자!!!!";
                    break;
                case 7:
                    si.text = "나는야 복학생!! 복학생 무시하지마라!";
                    break;
                case 8:
                    si.text = "졸업까지 최선을 다해 뽜이팅해보자!!!!!!";
                    break;
            }
        }
        

        if(num>8)
        {
            SceneManager.LoadScene("SubjectScene_1");
            GameObject.Find("player_done").transform.Find("Player").gameObject.SetActive(false);
        }
        
    }

    public IEnumerator FadeIn()
    {
        if (num > 8)
            StopCoroutine(FadeIn());
        else
        {
            si.color = new Color(si.color.r, si.color.g, si.color.b, 0);
            while (si.color.a < 1.0f)
            {
                si.color = new Color(si.color.r, si.color.g, si.color.b, si.color.a + (Time.deltaTime / 2.0f));
                yield return null;
            }
            num += 1;

            StartCoroutine(FadeOut());
        }

    }

    IEnumerator FadeOut()
    {
        si.color = new Color(si.color.r, si.color.g, si.color.b, 1);
        while(si.color.a>1.0f)
        {
            si.color = new Color(si.color.r, si.color.g, si.color.b, si.color.a - (Time.deltaTime / 2.0f));
            yield return null;
        }
        StartCoroutine(FadeIn());
    }
}
