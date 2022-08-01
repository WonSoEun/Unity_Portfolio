using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DialogCtr : MonoBehaviour
{
    public GameObject MoveBtn;
    public GameObject dialogBox;
    public Text textBox;
    private string dialog;
    public GameObject nextArrow;
    public int dialogNumber;  

    public TextAsset textFile;
    public string[] textLines;
    
    public int currentLine;
    public static int CheckLine;
    public int endAtLine;

    public bool next = false;
    public bool Move = true;
    //public bool first = false;
    //public static bool start = false;

    void Start()
    {
        // dialogNumber = 0;
        CheckLine = currentLine;
        nextArrow.SetActive(false);
        textBox.text = " ";
        // TextControl();

        // 텍스트 파일의 텍스트를 스트링 배열에 삽입
        if (textFile != null)
        {
            textLines = (textFile.text.Split('\n'));
            // 엔터가 들어간 구간 기준으로 줄 구분 (자름)
        }
        if (endAtLine == 0)
        {
            endAtLine = textLines.Length - 1;
        }
        StartCoroutine("TypingEffect");
    }

   /* private void TextControl()
    {
        StopCoroutine("TypingEffect");
        StopCoroutine("BlinkingArrow");
        nextArrow.SetActive(false);
        textBox.text = " ";

        if (dialogBox.activeInHierarchy == true)
        {
            StartCoroutine("TypingEffect");
        }
    }*/

    IEnumerator BlinkingArrow()
    {
        nextArrow.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        nextArrow.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        StartCoroutine("BlinkingArrow");
    }

    IEnumerator TypingEffect()
    {
        StopCoroutine("BlinkingArrow");
        string tempTextLine;
        tempTextLine = textLines[currentLine];
        textBox.text = " ";

        for (int i = 0; i < tempTextLine.Length; i++)
        {
            textBox.text += tempTextLine[i];
            yield return new WaitForSeconds(0.05f);
        }

        if (textBox.text != "")
        {
            StartCoroutine("BlinkingArrow");
        }
    }

    public void NextBtn()
    {              
        next = true;        
    }

    private void Update()
    {
        
        MoveBtn.SetActive(false);
        if (next)
        {
            currentLine += 1;
            CheckLine += 1;
            if (currentLine > endAtLine)
            {
                StopCoroutine("TypingEffect");
                StopCoroutine("BlinkingArrow");
                nextArrow.SetActive(false);
                dialogBox.SetActive(false);
                Move = false;
            }
            else
            {
                StopCoroutine("TypingEffect");
                StartCoroutine("TypingEffect");
            }
            next = false;

        }
        if (Move == false)
        {
            MoveBtn.SetActive(true);
        }

       /* if(first == true)
        {
            gameObject.SetActive(true);
        }*/
    }
}