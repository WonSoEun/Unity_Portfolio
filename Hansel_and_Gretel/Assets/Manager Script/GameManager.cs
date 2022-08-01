using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public static bool start = false;
    public static bool start_Library = false;
    public static int count_L;
       
    void Update()
    {
        
    }

    public void StartBtn()
    {
        SceneManager.LoadScene("Stage01_Bedroom");
        GameObject.Find("Inventory").transform.Find("Canvas").transform.Find("In2").gameObject.SetActive(true);
        start = true;
    }
    public void Restart()
    {
        SceneManager.LoadScene("TItle Scene"); 
        Retry();
    }

    public void BedDoor()
    {
        SceneManager.LoadScene("BedRoom_Door");
    }
    public void InB()
    {
        SceneManager.LoadScene("Stage01_Bedroom");
    }
   
    public void EnterL()
    {
        SceneManager.LoadScene("library");        
        if(count_L==0) start_Library = true;
        count_L+=1;
    }
    public void EnterB()
    {
        SceneManager.LoadScene("Stage01_Bedroom");
        DialogCtr.CheckLine = 15;
    }
    public void DialB_leave()
    {
        SceneManager.LoadScene("BedRoom_Door");
    }
    public void leaveL()
    {
        SceneManager.LoadScene("Corrider");
        DialogCtr.CheckLine = 3;
    }
    public void Enter_Bookcase()
    {
        if(Book_O_Click.get_O && Book_P_Click.get_P && Book_E_Click.get_E && Book_N_Click.get_N)
        {
            SceneManager.LoadScene("library_Bookcase");
        }
    }
    public void EnterS()
    {
        SceneManager.LoadScene("Secret Room");
    }
    public void leaveS()
    {
        SceneManager.LoadScene("library");
    }
    public void End()
    {
        Debug.Log("End");
    }
    public void ChestClick()
    {
        Invoke("ExtendChest", 0.5f);
    }
    public void ExtendChest()
    {
        SceneManager.LoadScene("Extend Chest");
    }
    public void Chest()
    {
        SceneManager.LoadScene("Stage01_Chest");
    }
    public void Back_Lib()
    {
        SceneManager.LoadScene("library");
    }
    public void Ent_Dial()
    {
        SceneManager.LoadScene("S_Dial");
    }
    public void DialSR_leave()
    {
        SceneManager.LoadScene("Secret Room");
    }
    public void Bed_Die()
    {
        SceneManager.LoadScene("Stage01_Bedroom_Die");
        Clean();
    }
    public void Book_Drop()
    {
        Invoke("Lib_Die", 1f);
    }
    public void Lib_Die()
    {
        SceneManager.LoadScene("library_Die");
        Clean();
    }
    public void Cake()
    {
        Invoke("Sec_Die", 0.4f);
    }
    public void Sec_Die()
    {
        SceneManager.LoadScene("Secret Room_Die");
        Clean();
    }

    void Clean()
    {
        GameObject.Find("Inventory").transform.Find("clock_In").gameObject.SetActive(false);
        GameObject.Find("Inventory").transform.Find("match_In").gameObject.SetActive(false);
        GameObject.Find("Inventory").transform.Find("book_O").gameObject.SetActive(false);
        GameObject.Find("Inventory").transform.Find("book_P").gameObject.SetActive(false);
        GameObject.Find("Inventory").transform.Find("book_E").gameObject.SetActive(false);
        GameObject.Find("Inventory").transform.Find("book_N").gameObject.SetActive(false);
    }

    void Retry()
    {
        Clock_Inven.Clock_Drop = false; //침실 배경 변경
        ClockClick.In_Clock = false; // 시계바늘 보이게
        CoverControll.touchCover_G = 0; //이불
        CoverControll.touchCover_H = 0; //이불
        GameObject.Find("Inventory").transform.Find("clock_In").transform.position = new Vector2(7.8f, 3.6f);//시계바늘 위치로
        Clock_Inven.check = false;  //시계바늘 체크해제
        MatchClick.In_Match = false; // 성냥 보이게
        GameObject.Find("Inventory").transform.Find("match_In").transform.position = new Vector2(7.95f, 1.21f);//시계바늘 위치로
        Match_Inven.check = false; //성냥 체크해제
        B_Dial.open_Is = false;
        //-----------------침실 초기화 성공------------------//
        Match_Inven.Match_Drop = false;
        B_Dial_Clik.count_C = 0;
        //-----------------복도 초기화 성공------------------//
        Book_E_Click.get_E = false;
        Book_N_Click.get_N = false;
        Book_O_Click.get_O = false;
        Book_P_Click.get_P = false;
        Bookcase_IN.open_Is_bookcase = false;
        GameObject.Find("Inventory").transform.Find("book_O").transform.position = new Vector3(7.91f, 3.8f,-1.3f);
        GameObject.Find("Inventory").transform.Find("book_P").transform.position = new Vector3(7.83f, 1.12f, -1.3f);
        GameObject.Find("Inventory").transform.Find("book_E").transform.position = new Vector3(7.8f, -1.01f, -1.3f);
        GameObject.Find("Inventory").transform.Find("book_N").transform.position = new Vector3(7.88f, -3.53f, -1.3f);
        Bookcase_IN.First = false;
        Bookcase_IN.Second = false;
        Bookcase_IN.Third = false;
        Bookcase_IN.Fourth = false;
        Book_O.book_First_O = false;
        Book_O.book_Second_O = false;
        Book_O.book_Third_O = false;
        Book_O.book_Fourth_O = false;
        Book_P.book_First_P = false;
        Book_P.book_Second_P = false;
        Book_P.book_Third_P = false;
        Book_P.book_Fourth_P = false;
        Book_E.book_First_E = false;
        Book_E.book_Second_E = false;
        Book_E.book_Third_E = false;
        Book_E.book_Fourth_E = false; 
        Book_N.book_First_N = false;
        Book_N.book_Second_N = false;
        Book_N.book_Third_N = false;
        Book_N.book_Fourth_N = false;
        Book_O.set_is_O = false;
        Book_P.set_is_P = false;
        Book_E.set_is_E = false;
        Book_N.set_is_N = false;
        Book_O.retry_is = true;
        Book_P.retry_is = true;
        Book_E.retry_is = true;
        Book_N.retry_is = true;
        Book_E.check = false;
        Book_O.check = false;
        Book_P.check = false;
        Book_N.check = false;
        Bookcase_IN.open_Is_bookcase = false;
        Bookcase_IN.set = false;
        count_L = 0;
        //-----------------서재 초기화 성공------------------//
        To_SecretRoom.count_S = 0;
        CurtainControll.touchCount = 0;
        Dial_S.open_Is = false;

    }
}
