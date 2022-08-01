using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterControll : MonoBehaviour
{
    public GameObject letter_ON;
    

    public void LetterClick()
    {
        letter_ON.SetActive(true);
    }

    public void BackClick()
    {
        letter_ON.SetActive(false);
    }
}
