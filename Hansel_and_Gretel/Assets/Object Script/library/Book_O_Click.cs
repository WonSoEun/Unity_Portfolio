using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book_O_Click : MonoBehaviour
{
    public static bool get_O = false;
    private void OnMouseDown()
    {
        gameObject.SetActive(false);
        GameObject.Find("Inventory").transform.Find("book_O").gameObject.SetActive(true);
        get_O = true;
    }
    void Update()
    {
        if (Bookcase_IN.open_Is_bookcase)
        {
            gameObject.SetActive(false);
        }
    }
}
