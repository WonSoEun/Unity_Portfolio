using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingList : MonoBehaviour
{
    public GameObject Ending;

    public Sprite[] Endinglist_shape; //엔딩 버튼마다 BG바꾸기
    
    SpriteRenderer Endinglist_BG;

    

    
    void Start()
    {
        Endinglist_BG = GetComponent<SpriteRenderer>();
        Ending.SetActive(false);
    }

    void Update()
    {
        
    }

    public void Excellent() //우수한 졸업 엔딩 활성화
    {
        if(EndingManager.isExcellent)
        {
            GameObject.Find("Character_EndingList").gameObject.transform.Find("Character").gameObject.SetActive(true);
            GameObject.Find("Canvas").gameObject.transform.Find("Btn").gameObject.SetActive(false);
            Endinglist_BG.sprite = Endinglist_shape[0];
            Ending.SetActive(true);
        }
    }

    public void easy() //무난한 졸업 엔딩 활성화
    {
        if (EndingManager.iseasy)
        {
            GameObject.Find("Character_EndingList").gameObject.transform.Find("Character").gameObject.SetActive(true);
            GameObject.Find("Canvas").gameObject.transform.Find("Btn").gameObject.SetActive(false);
            Endinglist_BG.sprite = Endinglist_shape[1];
            Ending.SetActive(true);
        }
    }

    public void common() //평범한 졸업 엔딩 활성화
    {
        if(EndingManager.iscommon)
        {
            GameObject.Find("Character_EndingList").gameObject.transform.Find("Character").gameObject.SetActive(true);
            GameObject.Find("Canvas").gameObject.transform.Find("Btn").gameObject.SetActive(false);
            Endinglist_BG.sprite = Endinglist_shape[2];
            Ending.SetActive(true);
        }

    }

    public void pullUp() //간신히 턱걸이 엔딩 활성화
    {
        if(EndingManager.ispullUp)
        {
            GameObject.Find("Character_EndingList").gameObject.transform.Find("Character").gameObject.SetActive(true);
            GameObject.Find("Canvas").gameObject.transform.Find("Btn").gameObject.SetActive(false);
            Endinglist_BG.sprite = Endinglist_shape[3];
            Ending.SetActive(true);
        }
    }

    public void FEnding() //F재수강 엔딩 활성화
    {
        if(EndingManager.isF)
        {
            GameObject.Find("Character_EndingList").gameObject.transform.Find("Character").gameObject.SetActive(true);
            GameObject.Find("Canvas").gameObject.transform.Find("Btn").gameObject.SetActive(false);
            Endinglist_BG.sprite = Endinglist_shape[4];
            Ending.SetActive(true);
        }
    }

    public void Back_EndingList() //엔딩리스트에서의 엔딩목록 버튼
    {
        Ending.SetActive(false);
        GameObject.Find("Character_EndingList").gameObject.transform.Find("Character").gameObject.SetActive(false);
        GameObject.Find("Canvas").gameObject.transform.Find("Btn").gameObject.SetActive(true);
    }

    public void restart_From_EndingList(string restart) //엔딩리스트에서의 다시하기 버튼
    {
        GameObject.Find("Character_EndingList").gameObject.transform.Find("Character").gameObject.SetActive(false);
        SceneManager.LoadScene(restart);
    }
}
