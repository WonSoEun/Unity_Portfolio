using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Match_Inven : MonoBehaviour
{
    string ClickName;
    public static bool check = false;
    public static bool Match_Drop;
    private Vector2 MatchPos;
    private Vector2 holePos;

    private void OnMouseDown()
    {
        MatchPos = this.transform.position;
        ClickName = this.gameObject.name;
        Debug.Log("MatchPos = " + MatchPos);
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
        //this.transform.position = new Vector3(7.8f, 1.3f, 0);
        if (check == false)
        {
            this.transform.position = MatchPos;
        }
        else
        {
            transform.position = holePos;
            Match_Drop = true;
            gameObject.SetActive(false);
        }
    }
}
