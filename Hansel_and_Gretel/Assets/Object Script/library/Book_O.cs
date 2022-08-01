using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book_O : MonoBehaviour
{
    public static bool book_First_O;
    public static bool book_Second_O;
    public static bool book_Third_O;
    public static bool book_Fourth_O;

    public static bool check = false;
    public static bool set_is_O = false;
    public static bool retry_is = false;
    public static Vector2 bookPos_O;
    private Vector2 holePos_O;
    SpriteRenderer sr;
    Sprite book_O;
    Sprite book_O_;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        book_O = Resources.Load<Sprite>("책_O");
        book_O_ = Resources.Load<Sprite>("book1");
    }

    private void OnMouseDown()
    {
        bookPos_O = this.transform.position;
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
            this.transform.position = bookPos_O;
        }
        else
        {
            transform.position = holePos_O;
            
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BookCase_1" && Bookcase_IN.First == false && check == false)
        {
            Debug.Log("첫번째 칸 들어감.O");
            book_First_O = true;
            Bookcase_IN.First = true;
            check = true;
            holePos_O = collision.gameObject.transform.position;
            sr.sprite = book_O;
        }
        if (collision.gameObject.tag == "BookCase_2" && Bookcase_IN.First && check == false)
        {
            Debug.Log("두번쨰 칸 들어감.O");
            book_Second_O = true;
            Bookcase_IN.Second = true;
            check = true;
            holePos_O = collision.gameObject.transform.position;
            sr.sprite = book_O;
        }
        if (collision.gameObject.tag == "BookCase_3" && Bookcase_IN.Second && check == false)
        {
            Debug.Log("세번쨰 칸 들어감.O");
            book_Third_O = true;
            Bookcase_IN.Third = true;
            check = true;
            holePos_O = collision.gameObject.transform.position;
            sr.sprite = book_O;
        }
        if (collision.gameObject.tag == "BookCase_4" && Bookcase_IN.Third && check == false)
        {
            Debug.Log("네번쨰 칸 들어감.O");
            book_Fourth_O = true;
            Bookcase_IN.Fourth = true;
            check = true;
            holePos_O = collision.gameObject.transform.position;
            sr.sprite = book_O;
        }
    }

    void Update()
    {
        if (Bookcase_IN.open_Is_bookcase)
        {
            GameObject.Find("Inventory").transform.Find("book_O").gameObject.SetActive(false);
        }
        if(Bookcase_IN.set)
        {
            sr.sprite = book_O_;
            set_is_O = true;
        }
        if (retry_is)
        {
            sr.sprite = book_O_;
            retry_is = false;

        }
    }
}
