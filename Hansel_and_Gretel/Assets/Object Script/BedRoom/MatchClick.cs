using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchClick : MonoBehaviour
{
    public GameManager GM;
    public GameObject matchM_BG;
    public GameObject match_in;

    public static bool In_Match = false;

    void Start()
    {
        if(In_Match==false)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }

        matchM_BG.SetActive(false);
    }

    private void OnMouseDown()
    {
        gameObject.SetActive(false);
        MatchMes();
    }

    public void MatchMes()
    {
        matchM_BG.SetActive(true);
    }
    
    public void OK_MBtn()
    {
        matchM_BG.SetActive(false);
        GameObject.Find("Inventory").transform.Find("match_In").gameObject.SetActive(true);
        //match_in.SetActive(true);
        In_Match = true;
    }

}
