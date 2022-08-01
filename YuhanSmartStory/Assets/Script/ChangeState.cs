using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeState : MonoBehaviour
{
    public GameObject Day_BG;
    public GameObject Week_BG;
    public GameObject Day_Btn;
    public GameObject Week_Btn;

    public GameObject day_Setting;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void Change()
    {
        Debug.Log("Load_location : " + DataSave.location);
        if (DataSave.location == "Week")
        {
            Setting_Week();
        }
        else if (DataSave.location == "Day")
        {
            Setting_Day();
        }
    }
    public void Setting_Week() 
    {
        day_Setting.SetActive(false);
        DataSave.location = "Week";
        Day_BG.SetActive(false);
        Day_Btn.SetActive(false);
        Week_BG.SetActive(true);
        Week_Btn.SetActive(true);
        
        GameObject.Find("player_done").transform.Find("Player").gameObject.transform.position
            = new Vector3(0, -0.45f, 0);
        GameObject.Find("player_done").transform.Find("Player").gameObject.SetActive(true);
    }

    public void Setting_Day()    
    {
        day_Setting.SetActive(true);
        DataSave.location = "Day";
        Day_BG.SetActive(true);
        Day_Btn.SetActive(true);
        Week_BG.SetActive(false);
        Week_Btn.SetActive(false);
        GameObject.Find("player_done").transform.Find("Player").gameObject.transform.position
            = new Vector3(0.95f, 1.37f, 0f);
        GameObject.Find("player_done").transform.Find("Player").gameObject.SetActive(true);
    }

   /* public void Setting_Week() //오브젝트 구성을 평일에서 주말로 바꾸기
    {
        GameObject.Find("Day_Setting").transform.Find("Desk").gameObject.SetActive(false);
        GameObject.Find("Day_Setting").transform.Find("Extra").gameObject.SetActive(false);
        DataSave.location = "Week";
        Day_BG.SetActive(false);
        Day_Btn.SetActive(false);
        Week_BG.SetActive(true);
        Week_Btn.SetActive(true);
        GameObject.Find("player_done").transform.Find("Player").gameObject.transform.position
            = new Vector3(0, -0.45f, 0);
    }

    public void Setting_Day()    //오브젝트 구성을 주말에서 평일로 바꾸기
    {
        GameObject.Find("Day_Setting").transform.Find("Desk").gameObject.SetActive(true);
        GameObject.Find("Day_Setting").transform.Find("Extra").gameObject.SetActive(true);
        DataSave.location = "Day";
        Day_BG.SetActive(true);
        Day_Btn.SetActive(true);
        Week_BG.SetActive(false);
        Week_Btn.SetActive(false);
        GameObject.Find("player_done").transform.Find("Player").gameObject.transform.position
            = new Vector3(0.95f, 1.37f, 0f);
    }*/
}
