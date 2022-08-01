using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public GameObject dialogBox;

    void awake()
    {
        GetComponent<CharacterB>();
    }

    void Update()
    {
        if(GameManager.start)
        {
            dialogBox.SetActive(true);
            Invoke("Wait_BedRoom", 1f);
        }
        if(B_Dial_Clik.start_corrider)
        {
            dialogBox.SetActive(true);
            Invoke("Wait_Corrider", 1f);
        }
        if(GameManager.start_Library)
        {
            dialogBox.SetActive(true);
            Invoke("Wait_Library", 1f);
        }
        if(To_SecretRoom.start_SecretRoom)
        {
            dialogBox.SetActive(true);
            Invoke("Wait_SecretRoom", 1f);
        }
        
    }
    void Wait_BedRoom()
    {
        GameManager.start = false;
    }
    void Wait_Corrider()
    {
        B_Dial_Clik.start_corrider = false;
    }
    void Wait_Library()
    {
        GameManager.start_Library = false;
    }
    void Wait_SecretRoom()
    {
        To_SecretRoom.start_SecretRoom = false;
    }
   
    /*public void ClickButton()
    {
        dialogBox.SetActive(true);
        DialogCtr call = GameObject.Find("Panel").GetComponent<DialogCtr>();
        call.currentLine = 0;
    }*/
}
