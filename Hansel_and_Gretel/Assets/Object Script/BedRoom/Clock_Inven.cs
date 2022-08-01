using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock_Inven : MonoBehaviour
{
    string ClickName;
    public static bool check = false;
    public static bool Clock_Drop;
    private Vector2 ClockPos;
    private Vector2 holePos;

    public GameObject Clock_show;

    
    private void OnMouseDown()
    {
        ClockPos = this.transform.position;
        ClickName = this.gameObject.name;
        Debug.Log("ClockPos = " + ClockPos);
        Debug.Log("ClickName = " + ClickName);
    }

    private void OnMouseDrag()
    {
        Vector2 cursorPos_C = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        transform.position = new Vector2(Mathf.Clamp(cursorPos_C.x, -8.0f, 8.0f),
            Mathf.Clamp(cursorPos_C.y, -4.0f, 4.0f));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(ClickName == collision.gameObject.tag)
        {
            check = true;
            holePos = collision.gameObject.transform.position;
            Debug.Log("드랍");
        }       
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        check = false;
    }

    private void OnMouseUp()
    {
        if(check==false)
        {
            this.transform.position = ClockPos;
        }
        else
        {
            transform.position = holePos;
            Clock_Drop = true;
            gameObject.SetActive(false);
        }

       /*if (gameObject.transform.position == new Vector3(0, 3.6f, 0))
        {
            gameObject.SetActive(false);
            Clock_show.SetActive(true);
        }*/
    }

}
