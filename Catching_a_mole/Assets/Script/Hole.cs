using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    Animator ani;
    AudioSource audioSource;

    bool touchPossible = false;
    bool boom;
    
    public AudioClip openSound;
    public AudioClip catchSound;
    public AudioClip boomSound;

    public GameManager gm;

    void Start()
    {
        ani = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    public void Open()
    {
        touchPossible = true;
        audioSource.clip = openSound;
        audioSource.Play();

        if(gm.gs==GameState.Ready) //9���� �� ó�� ������ Ȧ���� GoSound ���.
        {
            gm.Go();
        }
    }

    public void Close()
    {
        touchPossible = false;
    }

    private void OnMouseDown()
    {
        if (touchPossible)
        {
            touchPossible = false;
            ani.SetTrigger("isTouch");
            if (boom) //��ź Ŭ����
            {
                audioSource.clip = boomSound;
                audioSource.Play();
                gm.score -= 500;
            }
            else //�δ��� Ŭ����
            {
                audioSource.clip = catchSound;
                audioSource.Play();
                gm.score += 100;
            }
            
        }
    }

    public IEnumerator End()
    {
        yield return new WaitForSeconds(Random.Range(1.0f, 3.0f));
        float randomT = Random.Range(1.0f, 10.0f);

        if(gm.gs!=GameState.End)
        {
            if (randomT >= 5.0f)
            {
                boom = false;
                ani.SetTrigger("A_Open");
            }
            else
            {
                boom = true;
                ani.SetTrigger("B_Open");
            }
        }
        
    }

    void Update()
    {
        
    }
}
