using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dial_S : MonoBehaviour
{
    public int Num_1 = 1;
    public int Num_2 = 1;
    public int Num_3 = 1;
    public TextMeshProUGUI rp_1;
    public TextMeshProUGUI rp_2;
    public TextMeshProUGUI rp_3;

    public static bool open_Is = false;

    void Update()
    {
        switch (Num_1)
        {
            case 1:
                rp_1.text = "A";
                break;
            case 2:
                rp_1.text = "B";
                break;
            case 3:
                rp_1.text = "C";
                break;
            case 4:
                rp_1.text = "D";
                break;
            case 5:
                rp_1.text = "E";
                break;
            case 6:
                rp_1.text = "F";
                break;
            case 7:
                rp_1.text = "G";
                break;
            case 8:
                rp_1.text = "H";
                break;
            case 9:
                rp_1.text = "I";
                break;
            case 10:
                rp_1.text = "J";
                break;
            case 11:
                rp_1.text = "K";
                break;
            case 12:
                rp_1.text = "L";
                break;
            case 13:
                rp_1.text = "M";
                break;
            case 14:
                rp_1.text = "N";
                break;
            case 15:
                rp_1.text = "O";
                break;
            case 16:
                rp_1.text = "P";
                break;
            case 17:
                rp_1.text = "Q";
                break;
            case 18:
                rp_1.text = "R";
                break;
            case 19:
                rp_1.text = "S";
                break;
            case 20:
                rp_1.text = "T";
                break;
            case 21:
                rp_1.text = "U";
                break;
            case 22:
                rp_1.text = "V";
                break;
            case 23:
                rp_1.text = "W";
                break;
            case 24:
                rp_1.text = "X";
                break;
            case 25:
                rp_1.text = "Y";
                break;
            case 26:
                rp_1.text = "Z";
                break;
        }
        switch (Num_2)
        {
            case 1:
                rp_2.text = "A";
                break;
            case 2:
                rp_2.text = "B";
                break;
            case 3:
                rp_2.text = "C";
                break;
            case 4:
                rp_2.text = "D";
                break;
            case 5:
                rp_2.text = "E";
                break;
            case 6:
                rp_2.text = "F";
                break;
            case 7:
                rp_2.text = "G";
                break;
            case 8:
                rp_2.text = "H";
                break;
            case 9:
                rp_2.text = "I";
                break;
            case 10:
                rp_2.text = "J";
                break;
            case 11:
                rp_2.text = "K";
                break;
            case 12:
                rp_2.text = "L";
                break;
            case 13:
                rp_2.text = "M";
                break;
            case 14:
                rp_2.text = "N";
                break;
            case 15:
                rp_2.text = "O";
                break;
            case 16:
                rp_2.text = "P";
                break;
            case 17:
                rp_2.text = "Q";
                break;
            case 18:
                rp_2.text = "R";
                break;
            case 19:
                rp_2.text = "S";
                break;
            case 20:
                rp_2.text = "T";
                break;
            case 21:
                rp_2.text = "U";
                break;
            case 22:
                rp_2.text = "V";
                break;
            case 23:
                rp_2.text = "W";
                break;
            case 24:
                rp_2.text = "X";
                break;
            case 25:
                rp_2.text = "Y";
                break;
            case 26:
                rp_2.text = "Z";
                break;
        }
        switch (Num_3)
        {
            case 1:
                rp_3.text = "A";
                break;
            case 2:
                rp_3.text = "B";
                break;
            case 3:
                rp_3.text = "C";
                break;
            case 4:
                rp_3.text = "D";
                break;
            case 5:
                rp_3.text = "E";
                break;
            case 6:
                rp_3.text = "F";
                break;
            case 7:
                rp_3.text = "G";
                break;
            case 8:
                rp_3.text = "H";
                break;
            case 9:
                rp_3.text = "I";
                break;
            case 10:
                rp_3.text = "J";
                break;
            case 11:
                rp_3.text = "K";
                break;
            case 12:
                rp_3.text = "L";
                break;
            case 13:
                rp_3.text = "M";
                break;
            case 14:
                rp_3.text = "N";
                break;
            case 15:
                rp_3.text = "O";
                break;
            case 16:
                rp_3.text = "P";
                break;
            case 17:
                rp_3.text = "Q";
                break;
            case 18:
                rp_3.text = "R";
                break;
            case 19:
                rp_3.text = "S";
                break;
            case 20:
                rp_3.text = "T";
                break;
            case 21:
                rp_3.text = "U";
                break;
            case 22:
                rp_3.text = "V";
                break;
            case 23:
                rp_3.text = "W";
                break;
            case 24:
                rp_3.text = "X";
                break;
            case 25:
                rp_3.text = "Y";
                break;
            case 26:
                rp_3.text = "Z";
                break;
        }
        if (Num_1==27)
        {
            Num_1 = 1;
        }
        if(Num_2==27)
        {
            Num_2 = 1;
        }
        if(Num_3==27)
        {
            Num_3 = 1;
        }
        if(Num_1==11 && Num_2==9 && Num_3==4)
        {
            SceneManager.LoadScene("Secret Room");
            open_Is = true;
        }
    }
    
    public void Click_Btn1()
    {
        Num_1 += 1;
    }
    public void Click_Btn2()
    {
        Num_2 += 1;
    }
    public void Click_Btn3()
    {
        Num_3 += 1;
    }

    
}
