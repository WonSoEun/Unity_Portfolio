using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingControll : MonoBehaviour
{
    public GameObject Ending1_1;
    public GameObject Ending1_2;
    public GameObject Ending1_3;
    public GameObject Ending1_4;
    public GameObject Ending2;
    public GameObject Ending3;
    public GameObject Ending4;
    public GameObject Ending5;
    public GameObject Ending6;
    public GameObject Ending7;
    public GameObject Ending8;
    public GameObject Ending9;
    public GameObject Ending10;
    public GameObject Ending11;
    public GameObject Ending12;
    public GameObject Ending13;
    public GameObject Ending14;

    public GameObject restartBtn;

    private void Start()
    {
        Ending1_1.SetActive(true);
        Invoke("ending1_2", 2f);
    }

    void ending1_2()
    {
        Ending1_1.SetActive(false);
        Ending1_2.SetActive(true);
        Invoke("ending1_3", 3f);
    }

    void ending1_3()
    {
        Ending1_2.SetActive(false);
        Ending1_3.SetActive(true);
        Invoke("ending1_4", 3f);
    }

    void ending1_4()
    {
        Ending1_3.SetActive(false);
        Ending1_4.SetActive(true);
        Invoke("ending2", 2f);
    }

    void ending2()
    {
        Ending1_4.SetActive(false);
        Ending2.SetActive(true);
        Invoke("ending3", 1f);
    }
    void ending3()
    {
        Ending2.SetActive(false);
        Ending3.SetActive(true);
        Invoke("ending4", 1f);
    }

    void ending4()
    {
        Ending3.SetActive(false);
        Ending4.SetActive(true);
        Invoke("ending5", 1f);
    }
    void ending5()
    {
        Ending4.SetActive(false);
        Ending5.SetActive(true);
        Invoke("ending6", 1f);
    }
    void ending6()
    {
        Ending5.SetActive(false);
        Ending6.SetActive(true);
        Invoke("ending7", 1f);
    }
    void ending7()
    {
        Ending6.SetActive(false);
        Ending7.SetActive(true);
        Invoke("ending8", 2f);
    }
    void ending8()
    {
        Ending7.SetActive(false);
        Ending8.SetActive(true);
        Invoke("ending9", 1f);
    }
    void ending9()
    {
        Ending8.SetActive(false);
        Ending9.SetActive(true);
        Invoke("ending10", 1f);
    }

    void ending10()
    {
        Ending9.SetActive(false);
        Ending10.SetActive(true);
        Invoke("ending11", 1f);
    }

    void ending11()
    {        
        Ending11.SetActive(true);
        Invoke("ending12", 1f);
    }
    void ending12()
    {
        Ending11.SetActive(false);
        Ending12.SetActive(true);
        Invoke("ending13", 1f);
    }
    void ending13()
    {
        Ending12.SetActive(false);
        Ending13.SetActive(true);
        Invoke("ending14", 1f);
    }
    void ending14()
    {
        Ending13.SetActive(false);
        Ending14.SetActive(true);
        restartBtn.SetActive(true);
    }
}
