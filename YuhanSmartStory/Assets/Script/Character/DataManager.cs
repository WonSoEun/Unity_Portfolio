using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DataManager : MonoBehaviour
{
    public Image bar_physical; // ü�¹� �̹���
    public Image bar_stress; // ��Ʈ������ �̹���
    public Image bar_volition; // ������ �̹���
    public Image bar_creative; // â�Ƿ¹� �̹���
    public Image bar_thinking; // ���¹� �̹���
    public Image bar_knowledge; // ���Ĺ� �̹���

    public static bool restart = false;
    int start;

    void Start()
    { //ó�� �ɷ�ġ ����
        if (start == 0 && !restart)
            set_start();
        else if(restart)
        {
            bar_physical.fillAmount = DataSave.a;
            bar_stress.fillAmount = DataSave.b;
            bar_volition.fillAmount = DataSave.c;
            bar_creative.fillAmount = DataSave.d;
            bar_thinking.fillAmount = DataSave.e;
            bar_knowledge.fillAmount = DataSave.f;
        }
    }

    void Update()
    {
        
    }

    
   
    public void set_start() //ó�� ���� �ɷ�ġ(1���� ����ǰԲ�)
    {
        bar_physical.fillAmount = 1;
        bar_stress.fillAmount = 0;
        bar_volition.fillAmount = 0;
        bar_creative.fillAmount = 0.6f;
        bar_thinking.fillAmount = 0.6f;
        bar_knowledge.fillAmount = 0.6f;
        start += 1; 
    }

    public void Faithful() // '������'�� �������� �� �ش� �ɷ�ġ ǥ����.
    {
        bar_physical.fillAmount = 0.9f;
        bar_stress.fillAmount = 0.2f;
        bar_volition.fillAmount = 0.2f;
        bar_creative.fillAmount = 0.6f;
        bar_thinking.fillAmount = 0.6f;
        bar_knowledge.fillAmount = 0.6f;
    }

    public void Joyful() // '��ſ�'�� �������� �� �ش� �ɷ�ġ ǥ����.
    {
        bar_physical.fillAmount = 0.9f;
        bar_stress.fillAmount = 0.2f;
        bar_volition.fillAmount = 0;
        bar_creative.fillAmount = 0.6f;
        bar_thinking.fillAmount = 0.6f;
        bar_knowledge.fillAmount = 0.6f;
    }

    public void Proper() // '������'�� �������� �� �ش� �ɷ�ġ ǥ����.
    {
        bar_physical.fillAmount = 1;
        bar_stress.fillAmount = 0;
        bar_volition.fillAmount = 0;
        bar_creative.fillAmount = 0.6f;
        bar_thinking.fillAmount = 0.6f;
        bar_knowledge.fillAmount = 0.6f;
    }

    public void Excellent() // '�����'�� �������� �� �ش� �ɷ�ġ ǥ����.
    {
        bar_physical.fillAmount = 1;
        bar_stress.fillAmount = 0.2f;
        bar_volition.fillAmount = 0;
        bar_creative.fillAmount = 0.7f;
        bar_thinking.fillAmount = 0.7f;
        bar_knowledge.fillAmount = 0.7f;
    }

    public void Dishonesty() // '�Ҽ�����'�� �������� �� �ش� �ɷ�ġ ǥ����.
    {
        bar_physical.fillAmount = 1;
        bar_stress.fillAmount = 0.3f;
        bar_volition.fillAmount = 0;
        bar_creative.fillAmount = 0.6f;
        bar_thinking.fillAmount = 0.6f;
        bar_knowledge.fillAmount = 0.6f;
    }

    public void Glutinoues() // '�����ִ�'�� �������� �� �ش� �ɷ�ġ ǥ����.
    {
        bar_physical.fillAmount = 0.9f;
        bar_stress.fillAmount = 0.1f;
        bar_volition.fillAmount = 0.3f;
        bar_creative.fillAmount = 0.6f;
        bar_thinking.fillAmount = 0.6f;
        bar_knowledge.fillAmount = 0.6f;
    }

    public void Unthinking() // '������ ����'�� �������� �� �ش� �ɷ�ġ ǥ����.
    {
        bar_physical.fillAmount = 1;
        bar_stress.fillAmount = 0.2f;
        bar_volition.fillAmount = 0;
        bar_creative.fillAmount = 0.5f;
        bar_thinking.fillAmount = 0.5f;
        bar_knowledge.fillAmount = 0.5f;
    }
}
