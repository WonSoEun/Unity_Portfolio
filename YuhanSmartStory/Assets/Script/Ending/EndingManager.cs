using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingManager : MonoBehaviour
{

    public static bool isExcellent;
    public static bool iseasy;
    public static bool iscommon;
    public static bool ispullUp;
    public static bool isF;

    public Sprite[] Ending_BG_Initialize; //���������� BG �̹��� �����ϴ� �迭

    SpriteRenderer Ending_BG_Initialize_sp;

    void Start()
    {
        Ending_BG_Initialize_sp = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        
    }

    public void ReStart_Load(string restartScene)
    {
        SceneManager.LoadScene(restartScene);
    }

    public void EndingList_Load(string endinglistScene)
    {
        SceneManager.LoadScene(endinglistScene);
        Ending_BG_Initialize_sp.sprite = Ending_BG_Initialize[0];
    }

}
