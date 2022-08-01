using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public enum GameState
{
    Title = 0,
    GamePlay = 1,
    GameOver
}

public class GameManager : MonoBehaviour
{
    
    public static GameManager gm = null;

    public UnityEvent OnInitialize; //초기화
    public UnityEvent onBGStart; //bg setActive 실행이벤트

    public UnityEvent onReady; //bg setActive 실행이벤트
    public UnityEvent onStart; //bg setActive 실행이벤트

    public UnityEvent onPlayerStart; //bird 실행이벤트
    public UnityEvent onGameOver; // 게임오버되었을 때 실행이벤트
    public UnityEvent onSetPlayer; //플레이어 초기위치로 이동

    public GameState state = GameState.Title;

    int score = 0;
    public TextMeshProUGUI scoreText;

    public float count = 3;
    public TextMeshProUGUI timeText;
    bool start = false;
    bool ready = false;
    void Awake()
    {
        if (gm == null)
        {
            gm = this;
            state = GameState.Title;

        }
        else if(gm != this)
        {
            Destroy(gameObject);
        }

    }

    void Start()
    {
        score = 0;
        Initialize();
    }

    public void Initialize()
    {
        OnInitialize.Invoke(); //Title화면으로 초기화, bg setActive false로 해놓음
    }

    void Update()
    {
        scoreText.text = score.ToString();
        

        if(ready)
        {
            timeText.text = count.ToString("N0");
            count -= Time.deltaTime;
            if (count <= 1)
            {
                timeText.text = "";
                start = true;
                onStart.Invoke(); //스테이트 변경 1로
                ready = false;
            }
        }
        
    }

    public void ChangeGameState(int st) //스테이지가 변경되었을 때 모든 오브젝트에 신호 보내주는 함수
    {
        state = (GameState)st;
        if (st == 0) 
        {
            onSetPlayer.Invoke();
            //플레이어 setActive false해주고 위치조정 이벤트
        }
        if (st == 1) //게임 플레이 state로 변경되었다면,
        {
            count = 3;
            ready = true;
            
            if (start)
            {
                onSetPlayer.Invoke();
                onBGStart.Invoke(); //bg setActive true로 바꾸기, scrollspeed 주기
                onPlayerStart.Invoke(); //player에게 이동할수있다는 신호주기
            }
            
        }
        if (st == 2) //죽었다면
        {
            Debug.Log("죽었다");
            start = false;
            score = 0;
            onGameOver.Invoke(); //가속도 줄이고
            
        }
        if (st == 3) //UI 애니메이션 카운트다운
        {
            ready = true;
            onReady.Invoke();
        }
    }

    public void GetScore()
    {
        score += 1;
    }

    // 타이틀 state : 0 --> 1 ( 버튼 눌렀을 때)
    // 플레이 state : 1 --> 2
    // 게임오버 state : 2 --> 0


}
