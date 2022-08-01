using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obd : MonoBehaviour
{
    public GameObject Door_C;
    public GameObject Door_O;

    void Awake()
    {
        GetComponent<B_Dial>();
    }
  
    void Update()
    {
        if(B_Dial.open_Is==true)
        {
            Door_C.SetActive(false);
            Door_O.SetActive(true);
        }
    }
}
