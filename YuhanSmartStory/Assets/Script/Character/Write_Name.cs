using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Write_Name : MonoBehaviour
{
    public Text name;

    private void Awake()
    {
        name.text = Input_Name.write;
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
