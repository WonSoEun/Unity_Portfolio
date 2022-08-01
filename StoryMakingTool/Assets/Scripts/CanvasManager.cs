using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CanvasManager : MonoBehaviour
{
    public UnityEvent canvas01;
    public UnityEvent canvas02;
    public UnityEvent canvas03;
    public UnityEvent canvas04;
    public UnityEvent canvas05;
    public UnityEvent canvas06;

    public void Chapter1_Btn()
    {
        canvas01.Invoke();
    }
    public void Chapter2_Btn()
    {
        canvas02.Invoke();
    }
    public void Chapter3_Btn()
    {
        canvas03.Invoke();
    }
    public void Chapter4_Btn()
    {
        canvas04.Invoke();
    }
    public void Chapter5_Btn()
    {
        canvas05.Invoke();
    }
    public void Chapter6_Btn()
    {
        canvas06.Invoke();
    }
}
