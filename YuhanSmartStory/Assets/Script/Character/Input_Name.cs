using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Input_Name : MonoBehaviour
{
    public InputField input_Name;
    public static string write;

    void Start()
    {
        
    }

    void Update()
    {
        write = input_Name.text;
    }

    
}
