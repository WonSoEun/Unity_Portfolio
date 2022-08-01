using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book_N : MonoBehaviour
{
    public static bool book_First_N;
    public static bool book_Second_N;
    public static bool book_Third_N;
    public static bool book_Fourth_N;

    public static bool check = false;
    public static bool set_is_N = false;
    public static bool retry_is = false;
    public static Vector2 bookPos_N;
    private Vector2 holePos_N;
    SpriteRenderer sr;
    Sprite book_N;
    Sprite book_N_;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        book_N = Resources.Load<Sprite>("책_N");
        book_N_ = Resources.Load<Sprite>("book4");
    }

    private void OnMouseDown()
    {
        bookPos_N = this.transform.position;
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
            this.transform.position = bookPos_N;
        }
        else
        {
            transform.position = holePos_N;
            
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BookCase_1" && Bookcase_IN.First == false && check == false)
        {
            Debug.Log("첫번째 칸 들어감.N");
            book_First_N = true;
            Bookcase_IN.First = true;
            check = true;
            holePos_N = collision.gameObject.transform.position;
            sr.sprite = book_N;
        }
        if (collision.gameObject.tag == "BookCase_2" && Bookcase_IN.First && check == false)
        {
            Debug.Log("두번쨰 칸 들어감.N");
            book_Second_N = true;
            Bookcase_IN.Second = true;
            check = true;
            holePos_N = collision.gameObject.transform.position;
            sr.sprite = book_N;
        }
        if (collision.gameObject.tag == "BookCase_3" && Bookcase_IN.Second && check == false)
        {
            Debug.Log("세번쨰 칸 들어감.N");
            book_Third_N = true;
            Bookcase_IN.Third = true;
            check = true;
            holePos_N = collision.gameObject.transform.position;
            sr.sprite = book_N;
        }
        if (collision.gameObject.tag == "BookCase_4" && Bookcase_IN.Third && check == false)
        {
            Debug.Log("네번쨰 칸 들어감.N");
            book_Fourth_N = true;
            Bookcase_IN.Fourth = true;
            check = true;
            holePos_N = collision.gameObject.transform.position;
            sr.sprite = book_N;
        }
    }

    void Update()
    {
        if (Bookcase_IN.open_Is_bookcase)
        {
            GameObject.Find("Inventory").transform.Find("book_N").gameObject.SetActive(false);
        }
        if(Bookcase_IN.set)
        {
            sr.sprite = book_N_;
            set_is_N = true;
        }
        if (retry_is)
        {
            sr.sprite = book_N_; 
            retry_is = false;

        }
    }
}
