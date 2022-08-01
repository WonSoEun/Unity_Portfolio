using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockClick : MonoBehaviour
{
    public GameManager GM;
    public GameObject clockM_BG;
    public GameObject clock_In;    

    public static bool In_Clock = false;

    void Start()
    {
        if (In_Clock == false)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }

        clockM_BG.SetActive(false);
    }

    private void OnMouseDown()
    {
        gameObject.SetActive(false);
        ClockMes();
    }

    public void ClockMes()
    {
        clockM_BG.SetActive(true);
    }

    public void OK_CBtn()
    {
        clockM_BG.SetActive(false);
        GameObject.Find("Inventory").transform.Find("clock_In").gameObject.SetActive(true);
        //clock_In.SetActive(true);
        In_Clock = true;
    }
}
