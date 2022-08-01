using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MatchDrop : MonoBehaviour
{
    public GameObject Drop_Before;
    public GameObject Drop_After;
    public GameObject letterbtn;

    void Awake()
    {
        GetComponent<Match_Inven>();
    }

    void Update()
    {
        if (Match_Inven.Match_Drop == true)
        {
            Drop_Before.SetActive(false);
            Drop_After.SetActive(true);
            letterbtn.SetActive(true);
        }
    }
}