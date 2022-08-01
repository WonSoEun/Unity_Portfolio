using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book_E : MonoBehaviour
{
    public static bool book_First_E;
    public static bool book_Second_E;
    public static bool book_Third_E;
    public static bool book_Fourth_E;

    public static bool check = false;
    public static bool set_is_E = false;
    public static bool retry_is = false;
    public static Vector2 bookPos_E;
    private Vector2 holePos_E;
    SpriteRenderer sr;
    Sprite book_E;
    Sprite book_E_;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        book_E = Resources.Load<Sprite>("책_E");
        book_E_ = Resources.Load<Sprite>("book3");
    }

    private void OnMouseDown()
    {
        bookPos_E = this.transform.position;
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
            this.transform.position = bookPos_E;
        }
        else
        {
            transform.position = holePos_E;
            
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BookCase_1" && Bookcase_IN.First == false && check == false)
        {
            Debug.Log("첫번째 칸 들어감.E");
            book_First_E = true;
            Bookcase_IN.First = true;
            check = true;
            holePos_E = collision.gameObject.transform.position;
            sr.sprite = book_E;
        }
        if (collision.gameObject.tag == "BookCase_2" && Bookcase_IN.First && check == false)
        {
            Debug.Log("두번쨰 칸 들어감.E");
            book_Second_E = true;
            Bookcase_IN.Second = true;
            check = true;
            holePos_E = collision.gameObject.transform.position;
            sr.sprite = book_E;
        }
        if (collision.gameObject.tag == "BookCase_3" && Bookcase_IN.Second && check == false)
        {
            Debug.Log("세번쨰 칸 들어감.E");
            book_Third_E = true;
            Bookcase_IN.Third = true;
            check = true;
            holePos_E = collision.gameObject.transform.position;
            sr.sprite = book_E;
        }
        if (collision.gameObject.tag == "BookCase_4" && Bookcase_IN.Third && check == false)
        {
            Debug.Log("네번쨰 칸 들어감.E");
            book_Fourth_E = true;
            Bookcase_IN.Fourth = true;
            check = true;
            holePos_E = collision.gameObject.transform.position;
            sr.sprite = book_E;
        }
    }
    void Update()
    {
        if (Bookcase_IN.open_Is_bookcase)
        {
            GameObject.Find("Inventory").transform.Find("book_E").gameObject.SetActive(false);
        }
        if(Bookcase_IN.set)
        {
            sr.sprite = book_E_;
            set_is_E = true;
        }
        if(retry_is)
        {
            sr.sprite = book_E_;
            retry_is = false;

        }
    }
}
