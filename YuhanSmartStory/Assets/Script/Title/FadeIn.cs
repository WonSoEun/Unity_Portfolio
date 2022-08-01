using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeIn : MonoBehaviour
{
    public string SceneName;

    public Image Panel;
    float time = 0f;
    float F_time = 1f;

    public AudioClip clickSound;

    public ChangeState cs;

    public void Fade()
    {
        SoundManager.instance.SoundPlay("clickSound", clickSound);
        Initialization();
        StartCoroutine(FadeFlow());
    }
    public void Load_Fade()
    {
        SoundManager.instance.SoundPlay("clickSound", clickSound);
        cs.Change();
        StartCoroutine(FadeFlow());
    }
    IEnumerator FadeFlow()
    {
        Panel.gameObject.SetActive(true);
        time = 0f;
        Color alpha = Panel.color;
        while (alpha.a < 1f)
        {
            time += Time.deltaTime / F_time;
            alpha.a = Mathf.Lerp(0, 1, time);
            Panel.color = alpha;
            yield return null;
        }
        time = 0f;
        SceneManager.LoadScene(SceneName);
        yield return new WaitForSeconds(1f);
    }

    public void Initialization() //변수 초기화
    {
        //변수 초기화
        
        FadeInOut_Text.num = 0; //시놉시스 변수 초기화
        Subject_check.First_click_Num = 0; //과목설정 변수 초기화
        Subject_check.Second_click_Num = 0;
        Subject_check.Third_click_Num = 0;
        Subject_check.Fourth_click_Num = 0;
        Subject_check.Fiveth_click_Num = 0;
        Subject_check.Sixth_click_Num = 0;

        Subject_check.First_Subject_Num = 0;
        Subject_check.Second_Subject_Num = 0;
        Subject_check.Third_Subject_Num = 0;
        Subject_check.Fourth_Subject_Num = 0;
        Subject_check.Fiveth_Subject_Num = 0;
        Subject_check.Sixth_Subject_Num = 0;
        Subject_check.CheckMax = 0;

        CharacterManager.New = false; //캐릭터 별 시놉시스 텍스트 초기화
        CharacterManager.Old = false;
        CharacterManager.nature = 0;
        Debug.Log("초기화");
    }
}
