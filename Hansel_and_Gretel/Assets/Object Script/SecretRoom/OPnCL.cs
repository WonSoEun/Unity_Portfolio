using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OPnCL : MonoBehaviour
{
    public GameObject Door_CL;
    public GameObject Door_OP;    

    void Awake()
    {
        GetComponent<Dial_S>();
    }
    
    void Update()
    {
        if (Dial_S.open_Is)
        {
            Door_OP.SetActive(true);
            Door_CL.SetActive(false);
        }
        else
        {
            Door_OP.SetActive(false);
            Door_CL.SetActive(true);
        }
    }
}