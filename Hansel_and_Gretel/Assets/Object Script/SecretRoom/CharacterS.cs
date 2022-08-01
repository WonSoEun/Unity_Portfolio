using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterS : MonoBehaviour
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
            boy_Embarrassed.SetActive(true);
        }
        if (DialogCtr.CheckLine == 1)
        {
            boy_Embarrassed.SetActive(false);
            girl_Bright.SetActive(true);
        }
        if (DialogCtr.CheckLine == 2)
        {
            girl_Bright.SetActive(false);
        }
    }
}
