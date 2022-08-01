using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterB : MonoBehaviour
{
    public GameObject boy;
    public GameObject boy_Embarrassed;
    public GameObject boy_Surprised;
    public GameObject girl;
    public GameObject girl_Bright;
    public GameObject girl_Embarrassed;
    public GameObject cat;
    public GameObject catBack;

    void awake()
    {
        GetComponent<DialogCtr>();
    }
    
    void Update()
    {
        if (DialogCtr.CheckLine == 0)
        {
            girl.SetActive(true);
        }
        if (DialogCtr.CheckLine == 1)
        {
            boy.SetActive(true);
            girl.SetActive(false);
        }
        if (DialogCtr.CheckLine == 2)
        {
            boy.SetActive(false);
        }
        if (DialogCtr.CheckLine == 3)
        {
            cat.SetActive(true);
        }
        if (DialogCtr.CheckLine == 4)
        {
            cat.SetActive(false);
            boy_Embarrassed.SetActive(true);
        }
        if (DialogCtr.CheckLine == 5)
        {
            cat.SetActive(true);
            boy_Embarrassed.SetActive(false);
        }
        if (DialogCtr.CheckLine == 6)
        {

        }
        if (DialogCtr.CheckLine == 7)
        {
            cat.SetActive(false);
            girl_Embarrassed.SetActive(true);
        }
        if (DialogCtr.CheckLine == 8)
        {
            girl_Embarrassed.SetActive(false);
            cat.SetActive(true);
        }
        if (DialogCtr.CheckLine == 9)
        {
            cat.SetActive(false);
            girl_Bright.SetActive(true);
        }
        if (DialogCtr.CheckLine == 10)
        {
            girl_Bright.SetActive(false);
            cat.SetActive(true);
        }
        if (DialogCtr.CheckLine == 11)
        {
            cat.SetActive(false);
            girl_Bright.SetActive(true);
        }
        if (DialogCtr.CheckLine == 12)
        {
            girl_Bright.SetActive(false);
            boy.SetActive(true);
        }
        if (DialogCtr.CheckLine == 13)
        {
            girl_Embarrassed.SetActive(true);
            boy.SetActive(false);
        }
        if (DialogCtr.CheckLine == 14)
        {
            catBack.SetActive(true);
            girl_Embarrassed.SetActive(false);
        }
        if (DialogCtr.CheckLine == 15)
        {
            catBack.SetActive(false);
        }
    }
}
