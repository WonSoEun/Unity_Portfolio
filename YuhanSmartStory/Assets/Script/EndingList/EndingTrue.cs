using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EndingTrue : MonoBehaviour
{
    public Image Excellent_IMG; //우수한 졸업
    public Image easy_IMG; //무난한 졸업
    public Image common_IMG; //평범한 졸업
    public Image pullUp_IMG; //간신히 턱걸이
    public Image F_IMG; //F맞고 재수강
    
    public Sprite[] Endinglist_true; //엔딩을 봤다면, 물음표롤 하트모양으로 바꾸기

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
