using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CanvasControl : MonoBehaviour
{
    public UnityEvent onChangeStateToTitle; //Title
    public UnityEvent onChangeStateToPlay; //Play
    public UnityEvent onChangeStateToGameOver; //gameOver
    public UnityEvent onChangeStateNumberToPlay; //������Ʈ ��ȣ ����
    public UnityEvent onChangeStateNumberTostart; //������Ʈ ��ȣ ����


    public int state = 0;

    void Start()
    {
        
    }


    void Update()
    {
       
    }

    public void Initiailize()
    {
        state = 0;
        if (state == 0)
        {
            onChangeStateToTitle.Invoke();
        }
    }

    public void ChangeState(int st)
    {
        if(state != st)
        {
            if (state == 0) //Ÿ��Ʋ�� ��
            {
                onChangeStateToPlay.Invoke(); //�÷��� ȭ������ ��ȯ
                onChangeStateNumberToPlay.Invoke(); //�÷��� state�� �ٲ���ٴ� ���� gm���� ��ȣ�ѱ�.
            }
            else if (state == 1) //�׾����� 
            {
                onChangeStateToGameOver.Invoke();
            }
            else if (state == 2) //���ӿ������� ��ư ������ Title�� �Ѿ 
            {
                onChangeStateToTitle.Invoke();
                onChangeStateNumberTostart.Invoke();
                Debug.Log("�̰� ���ΰ�?");

            }
            state = st;
        }
    }


}
