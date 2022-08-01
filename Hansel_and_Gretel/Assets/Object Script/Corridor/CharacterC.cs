using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterC : MonoBehaviour
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
            boy.SetActive(true);
        }
        if (DialogCtr.CheckLine == 1)
        {
            girl_Embarrassed.SetActive(true);
            boy.SetActive(false);
        }
        if (DialogCtr.CheckLine == 3)
        {
            girl_Embarrassed.SetActive(false);
        }
    }
}
