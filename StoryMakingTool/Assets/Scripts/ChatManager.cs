using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

[System.Serializable]
public class StoryArray //대사 string 배열
{
    public string[] storyText; // string 배열. 대사를 적을 칸
    public Texture2D[] picture;
}

[System.Serializable]
public class ChoiceArray
{
    public int[] choiceInt; // 선택지 발생하는 위치(chatCount) int배열
}

[System.Serializable]
public class ChoiceObjArray
{
    public GameObject[] choiceObj; // 선택지 추가하는 배열
}

public class ChatManager : MonoBehaviour
{
    [Header("Basic Obj")]
    public GameObject yellowArea, whiteArea;
    public RectTransform contentRect;
    public Scrollbar scrollbar;
    AreaScript lastArea;
    public int chatCount; // 화면 클릭 시 1씩 커지며 
    public int oppenentCount;
    
    [Header("상대방 이름")]
    public string opponentName; // 상대방 이름
    //public Texture2D opponentImg; //상대방 이미지
    
    [Header("Story 대사")]
    public StoryArray[] chatList_Array; // string 배열. 대사를 적을 칸의 이중배열

    [Header("선택지")]
    public ChoiceObjArray[] choiceObj_Array;

    [Header("선택지 나오는 구간")]
    public ChoiceArray[] choiceOccurrence_Array;

    [Header("Next Chapter Button")]
    public GameObject nextChapterBtn;

    [Header("Return Button")]
    public GameObject returnBtn;

    bool goodChoice = false;
    bool onChoice = false;
    bool afterChoiceText = false;

    int gC = 0; // goodChoice
    int i = 0; // 선택지 출력을 위한 배열 수 세는 변수
    int j = 0; // 텍스트(내용)을 출력하기 위한 변수

    public void Chat(bool isSend, string text, string user, Texture2D picture)
    //Chat 함수 isSend = true 자신이 말함. false 상대방이 말함. text는 대사, user는 말하는 사람 이름, picture는 프로필사진
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
            if (Input.GetMouseButtonDown(0)) //화면 클릭시 다음 대화로 넘어감
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

    public void ChoiceCalculation() //선택지창 나오는 함수
    {
        if (chatCount > 0 && choiceOccurrence_Array[j].choiceInt.Length > i && chatCount == choiceOccurrence_Array[j].choiceInt[i] + 1) 
        {
            onChoice = true;
            choiceObj_Array[j].choiceObj[i].SetActive(true);
            i++;
        }
    }

    public void StoryWrite() //다음으로 넘어가는 Button함수
    {       
        if (chatCount % 2 == 0) // chatCount를 2로 나누었을 때 나머지가 0이면 나 자신이 말하는 것
        {
            Chat(true, chatList_Array[j].storyText[chatCount], null, null);
        }
        if (chatCount % 2 == 1) // 나머지가 1이면 상대방이 말하는 것 
        {
            if(afterChoiceText)
            {
                chatCount = 0;
                oppenentCount = 0;
                afterChoiceText = false;
            }
            Chat(false, chatList_Array[j].storyText[chatCount], opponentName, chatList_Array[j].picture[oppenentCount]); //윈터고민 좀 해볼게요
        }
        chatCount++; //함수가 호출될 때마다 1씩 증가 
        if(chatCount%2==0)
        {
            oppenentCount++;
        }
        if (onChoice == false && chatList_Array[j].storyText[chatCount] == "") //배열 공백이 있으면 다음으로 넘어감
        {
            chatCount++;
            oppenentCount--;
        }       
    }

    void Fit(RectTransform rect) => LayoutRebuilder.ForceRebuildLayoutImmediate(rect);

    void ScrollDelay() => scrollbar.value = 0;

    public void BadEndingChoice() //배드엔딩 선택지 함수(살짝 미완)
    {
        choiceObj_Array[j].choiceObj[i - 1].SetActive(false);
        Debug.Log("배드엔딩");
    }

    public void NextChoice(string choiceText)   // 다음으로 넘어가는 선택지함수
    {
        choiceObj_Array[j].choiceObj[i - 1].SetActive(false);
        Chat(true, choiceText, null, null);
        onChoice = false;
    }

    public void NextList(int listNumber)  // listNumber은 Text배열의 숫자이기에 해당번호의 string배열로 넘어간다.
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
