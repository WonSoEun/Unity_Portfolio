using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CanvasControl : MonoBehaviour
{
    public UnityEvent onChangeStateToTitle; //Title
    public UnityEvent onChangeStateToPlay; //Play
    public UnityEvent onChangeStateToGameOver; //gameOver
    public UnityEvent onChangeStateNumberToPlay; //스테이트 번호 변경
    public UnityEvent onChangeStateNumberTostart; //스테이트 번호 변경


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
            if (state == 0) //타이틀일 때
            {
                onChangeStateToPlay.Invoke(); //플레이 화면으로 전환
                onChangeStateNumberToPlay.Invoke(); //플레이 state로 바뀌었다는 것을 gm으로 신호넘김.
            }
            else if (state == 1) //죽었을때 
            {
                onChangeStateToGameOver.Invoke();
            }
            else if (state == 2) //게임오버에서 버튼 눌러서 Title로 넘어감 
            {
                onChangeStateToTitle.Invoke();
                onChangeStateNumberTostart.Invoke();
                Debug.Log("이게 끝인가?");

            }
            state = st;
        }
    }


}
