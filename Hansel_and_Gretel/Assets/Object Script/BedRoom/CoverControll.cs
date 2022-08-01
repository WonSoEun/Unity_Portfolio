using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoverControll : MonoBehaviour
{
    public GameObject GretelCover;
    public GameObject HenselCover;
    public static int touchCover_G = 0;
    public static int touchCover_H = 0;
    void Start()
    {
        GretelCover.SetActive(false);
        HenselCover.SetActive(false);
    }

    void Update()
    {
        if(touchCover_G%2==0)
        {
            GretelCover.SetActive(false);
        }
        else
        {
            GretelCover.SetActive(true);
        }

        if(touchCover_H%2==0)
        {
            HenselCover.SetActive(false);
        }
        else
        {
            HenselCover.SetActive(true);
        }
    }

    public void GretelCoverBtn()
    {
        touchCover_G += 1;
    }
    public void HenselCoverBtn()
    {
        touchCover_H += 1;   
    }
}
