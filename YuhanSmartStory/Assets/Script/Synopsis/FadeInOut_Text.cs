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
                    si.text = "�� ������ ������, �� 20���� �Ǿ���.";
                    break;
                case 1:
                    si.text = "��� ���� ���Ӱ� �������� ����!!";
                    break;
                case 2:
                    si.text = "���Ѵ� VR���Ӿ��а�������\n ���� ����??";
                    break;
                case 3:
                    si.text = "���� ������ � �б���Ȱ�� ������..?";
                    break;
                case 4:
                    si.text = "���� ��.. ���� ��..";
                    break;
                case 5:
                    si.text = "���� ���ϰھ�?!\n ������ ���� ���� ����� ����!";
                    break;
                case 6:
                    si.text = "�ֳ��ϸ�!!!!!!!!!!!";
                    break;
                case 7:
                    si.text = "���� ������, 20���̴ϱ�!!!!!!!!";
                    break;
                case 8:
                    si.text = "�������� �ּ��� ���� �������غ���!!!!!!";
                    break;
            }
        }else if(CharacterManager.Old)
        {
            switch (num)
            {
                case 0:
                    si.text = "���� ���л��̴�!!";
                    break;
                case 1:
                    si.text = "�������� �б��� ���� �Ǵٴ�\n ��ȸ�� ���ӱ�..";
                    break;
                case 2:
                    si.text = "��ġ��, ���� ��� ������\n �ϳ��� ����� ���� �ʴ´�..";
                    break;
                case 3:
                    si.text = "���� ������ � �б���Ȱ�� ������..?";
                    break;
                case 4:
                    si.text = "���� ��..�� �ƴ϶� ���� ����..";
                    break;
                case 5:
                    si.text = "ū���̾�!..���� ������ �����ؾ߰ھ�!!";
                    break;
                case 6:
                    si.text = "�Ҽ��ִ�, �ϸ�ȴ�, �غ���!!!!";
                    break;
                case 7:
                    si.text = "���¾� ���л�!! ���л� ������������!";
                    break;
                case 8:
                    si.text = "�������� �ּ��� ���� �������غ���!!!!!!";
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
