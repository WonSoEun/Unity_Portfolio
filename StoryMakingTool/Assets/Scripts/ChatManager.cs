using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

[System.Serializable]
public class StoryArray //��� string �迭
{
    public string[] storyText; // string �迭. ��縦 ���� ĭ
    public Texture2D[] picture;
}

[System.Serializable]
public class ChoiceArray
{
    public int[] choiceInt; // ������ �߻��ϴ� ��ġ(chatCount) int�迭
}

[System.Serializable]
public class ChoiceObjArray
{
    public GameObject[] choiceObj; // ������ �߰��ϴ� �迭
}

public class ChatManager : MonoBehaviour
{
    [Header("Basic Obj")]
    public GameObject yellowArea, whiteArea;
    public RectTransform contentRect;
    public Scrollbar scrollbar;
    AreaScript lastArea;
    public int chatCount; // ȭ�� Ŭ�� �� 1�� Ŀ���� 
    public int oppenentCount;
    
    [Header("���� �̸�")]
    public string opponentName; // ���� �̸�
    //public Texture2D opponentImg; //���� �̹���
    
    [Header("Story ���")]
    public StoryArray[] chatList_Array; // string �迭. ��縦 ���� ĭ�� ���߹迭

    [Header("������")]
    public ChoiceObjArray[] choiceObj_Array;

    [Header("������ ������ ����")]
    public ChoiceArray[] choiceOccurrence_Array;

    [Header("Next Chapter Button")]
    public GameObject nextChapterBtn;

    [Header("Return Button")]
    public GameObject returnBtn;

    bool goodChoice = false;
    bool onChoice = false;
    bool afterChoiceText = false;

    int gC = 0; // goodChoice
    int i = 0; // ������ ����� ���� �迭 �� ���� ����
    int j = 0; // �ؽ�Ʈ(����)�� ����ϱ� ���� ����

    public void Chat(bool isSend, string text, string user, Texture2D picture)
    //Chat �Լ� isSend = true �ڽ��� ����. false ������ ����. text�� ���, user�� ���ϴ� ��� �̸�, picture�� �����ʻ���
    {
        if (text.Trim() == "") return;

        bool isBottom = scrollbar.value <= 0.00001f;

        AreaScript area = Instantiate(isSend ? yellowArea : whiteArea).GetComponent<AreaScript>();
        area.transform.SetParent(contentRect.transform, false);
        area.boxRect.sizeDelta = new Vector2(600, area.boxRect.sizeDelta.y);
        area.textRect.GetComponent<Text>().text = text;
        Fit(area.boxRect);

        
        float x = area.textRect.sizeDelta.x + 42;
        float y = area.textRect.sizeDelta.y;

        if (y > 49)
        {
            for(int i = 0; i < 200; i++)
            {
                area.boxRect.sizeDelta = new Vector2(x - i * 2, area.boxRect.sizeDelta.y);
                Fit(area.boxRect);

                if(y != area.textRect.sizeDelta.y)
                {
                    area.boxRect.sizeDelta = new Vector2(x - i * 2 + 2, y);
                    break;
                }
            }
        }
        else
        {
            area.boxRect.sizeDelta = new Vector2(x, y);
        }

        bool isSame = lastArea != null;
        //area.tail.SetActive(!isSame);

        if(!isSend)
        {
            //area.userText.gameObject.SetActive(!isSame);
            //area.userImage.gameObject.SetActive(!isSame);
            area.userText.text = user;
            if (picture != null) area.userImage.sprite = Sprite.Create(picture, new Rect(0, 0, picture.width, picture.height), new Vector2(0.5f, 0.5f));
        }

        Fit(area.boxRect);
        Fit(area.areaRect);
        Fit(contentRect);
        lastArea = area;

        if (!isSend && !isBottom) return;
        Invoke("ScrollDelay", 0.03f);
    }

    private void Update()
    {
        ChoiceCalculation();
        try
        {
            if (Input.GetMouseButtonDown(0)) //ȭ�� Ŭ���� ���� ��ȭ�� �Ѿ
            {
                StoryWrite();
            }
        }
        catch (Exception)
        {
            
        }
        if(goodChoice && Input.GetMouseButtonDown(0))
        {
            gC++;
        }
        if(gC >= 1)
        {
            returnBtn.SetActive(true);
        }
        
    }

    public void ChoiceCalculation() //������â ������ �Լ�
    {
        if (chatCount > 0 && choiceOccurrence_Array[j].choiceInt.Length > i && chatCount == choiceOccurrence_Array[j].choiceInt[i] + 1) 
        {
            onChoice = true;
            choiceObj_Array[j].choiceObj[i].SetActive(true);
            i++;
        }
    }

    public void StoryWrite() //�������� �Ѿ�� Button�Լ�
    {       
        if (chatCount % 2 == 0) // chatCount�� 2�� �������� �� �������� 0�̸� �� �ڽ��� ���ϴ� ��
        {
            Chat(true, chatList_Array[j].storyText[chatCount], null, null);
        }
        if (chatCount % 2 == 1) // �������� 1�̸� ������ ���ϴ� �� 
        {
            if(afterChoiceText)
            {
                chatCount = 0;
                oppenentCount = 0;
                afterChoiceText = false;
            }
            Chat(false, chatList_Array[j].storyText[chatCount], opponentName, chatList_Array[j].picture[oppenentCount]); 
        }
        chatCount++; //�Լ��� ȣ��� ������ 1�� ���� 
        if(chatCount%2==0)
        {
            oppenentCount++;
        }
        if (onChoice == false && chatList_Array[j].storyText[chatCount] == "") //�迭 ������ ������ �������� �Ѿ
        {
            chatCount++;
            oppenentCount--;
        }       
    }

    void Fit(RectTransform rect) => LayoutRebuilder.ForceRebuildLayoutImmediate(rect);

    void ScrollDelay() => scrollbar.value = 0;

    public void BadEndingChoice() //��忣�� ������ �Լ�(��¦ �̿�)
    {
        choiceObj_Array[j].choiceObj[i - 1].SetActive(false);
        Debug.Log("��忣��");
    }

    public void NextChoice(string choiceText)   // �������� �Ѿ�� �������Լ�
    {
        choiceObj_Array[j].choiceObj[i - 1].SetActive(false);
        Chat(true, choiceText, null, null);
        onChoice = false;
    }

    public void NextList(int listNumber)  // listNumber�� Text�迭�� �����̱⿡ �ش��ȣ�� string�迭�� �Ѿ��.
    {
        j = listNumber;
        i = 0;
        chatCount = 1;
        afterChoiceText = true;
    }

    public void GoodChoice()
    {
        goodChoice = true;
        if (nextChapterBtn != null)
        {
            nextChapterBtn.SetActive(true);
        }
    }
}
