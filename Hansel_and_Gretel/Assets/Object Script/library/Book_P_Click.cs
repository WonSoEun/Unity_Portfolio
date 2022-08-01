using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book_P_Click : MonoBehaviour
{
    public static bool get_P = false;
    private void OnMouseDown()
    {
        gameObject.SetActive(false);
        GameObject.Find("Inventory").transform.Find("book_P").gameObject.SetActive(true);
        get_P = true;
    }
    void Update()
    {
        if (Bookcase_IN.open_Is_bookcase)
        {
            gameObject.SetActive(false);
        }
    }

}
