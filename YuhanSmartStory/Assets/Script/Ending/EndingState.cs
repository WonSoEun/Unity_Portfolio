using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingState : MonoBehaviour
{
    public Sprite[] con_sp;
    public Image condition;
    public Text condition_Text;

    void Start()
    {
        
    }

    void Update()
    {
        if (DataSave.a >= 0.9f && DataSave.b <= 0.1f)
        {
            condition.sprite = con_sp[0];
            condition_Text.text = "GOOD!";
        }
        if (0.75f <= DataSave.a && DataSave.a <= 0.9f &&
            0.1f <= DataSave.b && DataSave.b <= 0.25f)
        {
            condition.sprite = con_sp[1];
            condition_Text.text = "Normal~";
        }
        if (DataSave.a <= 0.25f && DataSave.b >= 0.75f)
        {
            condition.sprite = con_sp[2];
            condition_Text.text = "Worst!";
        }
    }
}
