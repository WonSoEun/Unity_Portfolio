using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class B_Dial : MonoBehaviour
{
    public int dialNum_1;
    public int dialNum_2;
    public int dialNum_3;
    public int dialNum_4;

    public TextMeshProUGUI NumText_1;
    public TextMeshProUGUI NumText_2;
    public TextMeshProUGUI NumText_3;
    public TextMeshProUGUI NumText_4;

    public static bool open_Is = false;

    
    void Update()
    {
        if (dialNum_1 == 1 && dialNum_2 == 2 && dialNum_3 == 2 && dialNum_4 == 5)
        {
            //Debug.Log("open");
            SceneManager.LoadScene("BedRoom_Door");
            open_Is = true;

        }
    }

    public void First()
    {
        dialNum_1++;
        NumText_1.text = "" + dialNum_1;
        if (dialNum_1 == 9)
        {
            dialNum_1 = -1;
        }
    }

    public void Second()
    {
        dialNum_2++;
        NumText_2.text = "" + dialNum_2;
        if (dialNum_2 == 9)
        {
            dialNum_2 = -1;
        }
    }

    public void Third()
    {
        dialNum_3++;
        NumText_3.text = "" + dialNum_3;
        if (dialNum_3 == 9)
        {
            dialNum_3 = -1;
        }
    }

    public void Fourth()
    {
        dialNum_4++;
        NumText_4.text = "" + dialNum_4;
        if (dialNum_4 == 9)
        {
            dialNum_4 = -1;
        }
    }
}
