using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EndingTrue : MonoBehaviour
{
    public Image Excellent_IMG; //����� ����
    public Image easy_IMG; //������ ����
    public Image common_IMG; //����� ����
    public Image pullUp_IMG; //������ �ΰ���
    public Image F_IMG; //F�°� �����
    
    public Sprite[] Endinglist_true; //������ �ôٸ�, ����ǥ�� ��Ʈ������� �ٲٱ�

    void Start()
    {
        
    }

    void Update()
    {
        if (EndingScene.Excel_true) 
        {
            Excellent_IMG.sprite = Endinglist_true[0];
        }
        if (EndingScene.easy_true)
        {
            easy_IMG.sprite = Endinglist_true[0];
        }
        if (EndingScene.common_true)
        {
            common_IMG.sprite = Endinglist_true[0];
        }
        if (EndingScene.pullup_true)
        {
            pullUp_IMG.sprite = Endinglist_true[0];
        }
        if (EndingScene.F_true)
        {
            F_IMG.sprite = Endinglist_true[0];
        }
    }
}
