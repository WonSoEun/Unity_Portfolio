using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterL : MonoBehaviour
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
            girl_Embarrassed.SetActive(true);
        }
        if (DialogCtr.CheckLine == 1)
        {
            girl_Embarrassed.SetActive(false);
            boy_Surprised.SetActive(true);
        }
        if (DialogCtr.CheckLine == 2)
        {
            boy_Surprised.SetActive(false);
        }
    }
}
