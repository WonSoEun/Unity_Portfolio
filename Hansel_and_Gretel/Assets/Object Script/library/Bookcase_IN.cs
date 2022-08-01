using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bookcase_IN : MonoBehaviour
{
    public static bool First = false;
    public static bool Second = false;
    public static bool Third = false;
    public static bool Fourth = false;

    public GameObject book_O;
    public GameObject book_P;
    public GameObject book_E;
    public GameObject book_N;

    public static bool Fail = false;
    public static bool open_Is_bookcase = false; //
    public static bool set = false;


    void Update()
    {
        if(First)
        {
            First = true;
        }
        if(Second)
        {
            Second = true;
        }
        if(Third)
        {
            Third = true;
        }
        if(Fourth)
        {
            Fourth = true;
        }
        if(First && Second && Third && Fourth)
        {
            if(Book_O.book_First_O && Book_P.book_Second_P
                && Book_E.book_Third_E && Book_N.book_Fourth_N)
            {
                Debug.Log("open 성공");
                Fail = false;
                SceneManager.LoadScene("library");//
                open_Is_bookcase = true; //
                
            }
            else
            {
                Debug.Log("실패");
               Fail = true;
            }
        }
        if(Book_O.set_is_O && Book_P.set_is_P && Book_E.set_is_E && Book_N.set_is_N)
        {
            set = false;
        }

    }
    public void reStart()
    {
        if(Fail)
        {
            book_O.transform.position = 
                GameObject.Find("Inventory").transform.Find("book_O").transform.position 
                = Book_O.bookPos_O;
            book_P.transform.position =
               GameObject.Find("Inventory").transform.Find("book_P").transform.position
               = Book_P.bookPos_P;
            book_E.transform.position =
               GameObject.Find("Inventory").transform.Find("book_E").transform.position
               = Book_E.bookPos_E;
            book_N.transform.position =
               GameObject.Find("Inventory").transform.Find("book_N").transform.position
               = Book_N.bookPos_N;
            set = true;
            First = false;
            Second = false;
            Third = false;
            Fourth = false;
            Book_O.check = false;
            Book_P.check = false;
            Book_E.check = false;
            Book_N.check = false;
            Fail = false;
        }
        
    }
    
}
