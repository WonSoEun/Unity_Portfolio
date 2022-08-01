using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book_N_Click : MonoBehaviour
{
    public static bool get_N = false;
    private void OnMouseDown()
    {
        gameObject.SetActive(false);
        GameObject.Find("Inventory").transform.Find("book_N").gameObject.SetActive(true);
        get_N = true;
    }
    void Update()
    {
        if (Bookcase_IN.open_Is_bookcase)
        {
            gameObject.SetActive(false);
        }
    }
}
