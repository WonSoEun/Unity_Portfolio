using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book_E_Click : MonoBehaviour
{
    public static bool get_E = false;
    private void OnMouseDown()
    {
        gameObject.SetActive(false);
        GameObject.Find("Inventory").transform.Find("book_E").gameObject.SetActive(true);
        get_E = true;
    }

    void Update()
    {
        if(Bookcase_IN.open_Is_bookcase)
        {
            gameObject.SetActive(false);
        }
    }
}
