using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bookcase_Open : MonoBehaviour
{
    public GameObject bookcase_C;
    public GameObject bookcase_O;

    void Awake()
    {
        GetComponent<Bookcase_IN>();    
    }
    void Update()
    {
        if(Bookcase_IN.open_Is_bookcase)
        {
            bookcase_C.SetActive(false);
            bookcase_O.SetActive(true);
        }
    }
}
