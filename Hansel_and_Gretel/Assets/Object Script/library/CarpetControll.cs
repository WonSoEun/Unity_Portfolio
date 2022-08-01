using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarpetControll : MonoBehaviour
{
    public GameObject Carpet;
    public int touchCarpet = 0;
    void Start()
    {
        Carpet.SetActive(false);
    }

    void Update()
    {
        if(touchCarpet%2==0)
        {
            Carpet.SetActive(false);
        }
        else
        {
            Carpet.SetActive(true);
        }
    }

    public void CarpetBtn()
    {
        touchCarpet++;
    }
}
