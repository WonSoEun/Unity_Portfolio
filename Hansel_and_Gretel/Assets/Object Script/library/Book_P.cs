using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book_P : MonoBehaviour
{
    public static bool book_First_P;
    public static bool book_Second_P;
    public static bool book_Third_P;
    public static bool book_Fourth_P;

    public static bool check = false;
    public static bool set_is_P = false;
    public static bool retry_is = false;
    public static Vector2 bookPos_P;
    private Vector2 holePos_P;
    SpriteRenderer sr;
    Sprite book_P;
    Sprite book_P_;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        book_P = Resources.Load<Sprite>("책_P");
        book_P_ = Resources.Load<Sprite>("book2");
    }

    private void OnMouseDown()
    {
        bookPos_P = this.transform.position;
    }

    private void OnMouseDrag()
    {
        Vector2 cursorPos_C = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        transform.position = new Vector2(Mathf.Clamp(cursorPos_C.x, -8.0f, 8.0f),
            Mathf.Clamp(cursorPos_C.y, -4.0f, 4.0f));
    }

    private void OnMouseUp()
    {
        if (check == false)
        {
            this.transform.position = bookPos_P;
        }
        else
        {
            transform.position = holePos_P; 
            
        }
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BookCase_1" && Bookcase_IN.First == false && check == false)
        {
            Debug.Log("첫번째 칸 들어감.P");
            book_First_P = true;
            Bookcase_IN.First = true;
            check = true;
            holePos_P = collision.gameObject.transform.position;
            sr.sprite = book_P;
        }
        if (collision.gameObject.tag == "BookCase_2" && Bookcase_IN.First && check == false)
        {
            Debug.Log("두번쨰 칸 들어감.P");
            book_Second_P = true;
            Bookcase_IN.Second = true;
            check = true;
            holePos_P = collision.gameObject.transform.position;
            sr.sprite = book_P;
        }
        if (collision.gameObject.tag == "BookCase_3" && Bookcase_IN.Second && check == false)
        {
            Debug.Log("세번쨰 칸 들어감.P");
            book_Third_P = true;
            Bookcase_IN.Third = true;
            check = true;
            holePos_P = collision.gameObject.transform.position;
            sr.sprite = book_P;
        }
        if (collision.gameObject.tag == "BookCase_4" && Bookcase_IN.Third && check == false)
        {
            Debug.Log("네번쨰 칸 들어감.P");
            book_Fourth_P = true;
            Bookcase_IN.Fourth = true;
            check = true;
            holePos_P = collision.gameObject.transform.position;
            sr.sprite = book_P;
        }
    }
    void Update()
    {
        if (Bookcase_IN.open_Is_bookcase)
        {
            GameObject.Find("Inventory").transform.Find("book_P").gameObject.SetActive(false);
        }
        if(Bookcase_IN.set)
        {
            sr.sprite = book_P_;
            set_is_P = true;
        }
        if (retry_is)
        {
            sr.sprite = book_P_;
            retry_is = false;
        }
    }
}
