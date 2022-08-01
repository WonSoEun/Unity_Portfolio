using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DataSave : MonoBehaviour
{
    public static int Week_Num = 1;
    public static float a, b, c, d, e, f;

    public static float Num;
    public static float sum;

    public static int A_Plus;
    public static int A;
    public static int B_Plus;
    public static int B;
    public static int C_Plus;
    public static int C;
    public static int D;
    public static int F;

    public static string subject1;
    public static string subject2;
    public static string subject3;
    public static string subject4;
    public static string subject5;
    public static string subject6;

    public static string location;

    public FadeIn fade;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void SaveBtn() //저장하기
    {
        PlayerPrefs.SetInt("Week_Num", Week_Num); //주차
        PlayerPrefs.SetInt("A_Plus", A_Plus); //학점
        PlayerPrefs.SetInt("A", A); 
        PlayerPrefs.SetInt("B_Plus", B_Plus); 
        PlayerPrefs.SetInt("B", B); 
        PlayerPrefs.SetInt("C_Plus", C_Plus); 
        PlayerPrefs.SetInt("C", C); 
        PlayerPrefs.SetInt("D", D); 
        PlayerPrefs.SetInt("F", F);

        PlayerPrefs.SetFloat("a", a); //능력치
        PlayerPrefs.SetFloat("b", b);
        PlayerPrefs.SetFloat("c", c);
        PlayerPrefs.SetFloat("d", d);
        PlayerPrefs.SetFloat("e", e);
        PlayerPrefs.SetFloat("f", f);

        PlayerPrefs.SetFloat("Num", Num); //점수학점계산
        PlayerPrefs.SetFloat("sum", sum);

        PlayerPrefs.SetString("MW", CharacterManager.MW);
        PlayerPrefs.SetString("NO", CharacterManager.NO);
        PlayerPrefs.SetString("Location", location);
        PlayerPrefs.SetString("name", Input_Name.write);

        PlayerPrefs.SetString("Subject1", subject1);
        PlayerPrefs.SetString("Subject2", subject2);
        PlayerPrefs.SetString("Subject3", subject3);
        PlayerPrefs.SetString("Subject4", subject4);
        PlayerPrefs.SetString("Subject5", subject5);
        PlayerPrefs.SetString("Subject6", subject6);

    }


    public void LoadBtn() //이어하기
    {
        Week_Num = PlayerPrefs.GetInt("Week_Num", Week_Num); //주차
        A_Plus = PlayerPrefs.GetInt("A_Plus", A_Plus); //학점
        A = PlayerPrefs.GetInt("A", A);
        B_Plus = PlayerPrefs.GetInt("B_Plus", B_Plus);
        B = PlayerPrefs.GetInt("B", B);
        C_Plus =  PlayerPrefs.GetInt("C_Plus", C_Plus);
        C = PlayerPrefs.GetInt("C", C);
        D = PlayerPrefs.GetInt("D", D);
        F = PlayerPrefs.GetInt("F", F);

        a = PlayerPrefs.GetFloat("a", a); //능력치
        b = PlayerPrefs.GetFloat("b", b);
        c = PlayerPrefs.GetFloat("c", c);
        d = PlayerPrefs.GetFloat("d", d);
        e = PlayerPrefs.GetFloat("e", e);
        f = PlayerPrefs.GetFloat("f", f);

        Num = PlayerPrefs.GetFloat("Num", Num); //점수학점계산
        sum = PlayerPrefs.GetFloat("sum", sum);

        CharacterManager.NO = PlayerPrefs.GetString("NO", CharacterManager.NO);
        CharacterManager.MW = PlayerPrefs.GetString("MW", CharacterManager.MW);
        location = PlayerPrefs.GetString("Location");
        Input_Name.write = PlayerPrefs.GetString("name", Input_Name.write);

        subject1 = PlayerPrefs.GetString("Subject1", subject1);
        subject2 = PlayerPrefs.GetString("Subject2", subject2);
        subject3 = PlayerPrefs.GetString("Subject3", subject3);
        subject4 = PlayerPrefs.GetString("Subject4", subject4);
        subject5 = PlayerPrefs.GetString("Subject5", subject5);
        subject6 = PlayerPrefs.GetString("Subject6", subject6);

        DataManager.restart = true;

        SceneManager.LoadScene("InGame_Day");
        fade.Load_Fade();
        

        //윗 값 저장 0
        //플레이어 정보 저장 0
        //과목명 정보 저장
        //엔딩 변수 정보 저장
        //닉네임 저장 0 
    }
}
