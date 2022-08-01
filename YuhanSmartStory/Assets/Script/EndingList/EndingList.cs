using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingList : MonoBehaviour
{
    public GameObject Ending;

    public Sprite[] Endinglist_shape; //���� ��ư���� BG�ٲٱ�
    
    SpriteRenderer Endinglist_BG;

    

    
    void Start()
    {
        Endinglist_BG = GetComponent<SpriteRenderer>();
        Ending.SetActive(false);
    }

    void Update()
    {
        
    }

    public void Excellent() //����� ���� ���� Ȱ��ȭ
    {
        if(EndingManager.isExcellent)
        {
            GameObject.Find("Character_EndingList").gameObject.transform.Find("Character").gameObject.SetActive(true);
            GameObject.Find("Canvas").gameObject.transform.Find("Btn").gameObject.SetActive(false);
            Endinglist_BG.sprite = Endinglist_shape[0];
            Ending.SetActive(true);
        }
    }

    public void easy() //������ ���� ���� Ȱ��ȭ
    {
        if (EndingManager.iseasy)
        {
            GameObject.Find("Character_EndingList").gameObject.transform.Find("Character").gameObject.SetActive(true);
            GameObject.Find("Canvas").gameObject.transform.Find("Btn").gameObject.SetActive(false);
            Endinglist_BG.sprite = Endinglist_shape[1];
            Ending.SetActive(true);
        }
    }

    public void common() //����� ���� ���� Ȱ��ȭ
    {
        if(EndingManager.iscommon)
        {
            GameObject.Find("Character_EndingList").gameObject.transform.Find("Character").gameObject.SetActive(true);
            GameObject.Find("Canvas").gameObject.transform.Find("Btn").gameObject.SetActive(false);
            Endinglist_BG.sprite = Endinglist_shape[2];
            Ending.SetActive(true);
        }

    }

    public void pullUp() //������ �ΰ��� ���� Ȱ��ȭ
    {
        if(EndingManager.ispullUp)
        {
            GameObject.Find("Character_EndingList").gameObject.transform.Find("Character").gameObject.SetActive(true);
            GameObject.Find("Canvas").gameObject.transform.Find("Btn").gameObject.SetActive(false);
            Endinglist_BG.sprite = Endinglist_shape[3];
            Ending.SetActive(true);
        }
    }

    public void FEnding() //F����� ���� Ȱ��ȭ
    {
        if(EndingManager.isF)
        {
            GameObject.Find("Character_EndingList").gameObject.transform.Find("Character").gameObject.SetActive(true);
            GameObject.Find("Canvas").gameObject.transform.Find("Btn").gameObject.SetActive(false);
            Endinglist_BG.sprite = Endinglist_shape[4];
            Ending.SetActive(true);
        }
    }

    public void Back_EndingList() //��������Ʈ������ ������� ��ư
    {
        Ending.SetActive(false);
        GameObject.Find("Character_EndingList").gameObject.transform.Find("Character").gameObject.SetActive(false);
        GameObject.Find("Canvas").gameObject.transform.Find("Btn").gameObject.SetActive(true);
    }

    public void restart_From_EndingList(string restart) //��������Ʈ������ �ٽ��ϱ� ��ư
    {
        GameObject.Find("Character_EndingList").gameObject.transform.Find("Character").gameObject.SetActive(false);
        SceneManager.LoadScene(restart);
    }
}
