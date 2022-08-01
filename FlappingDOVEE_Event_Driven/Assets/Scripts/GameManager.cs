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

    public UnityEvent OnInitialize; //�ʱ�ȭ
    public UnityEvent onBGStart; //bg setActive �����̺�Ʈ

    public UnityEvent onReady; //bg setActive �����̺�Ʈ
    public UnityEvent onStart; //bg setActive �����̺�Ʈ

    public UnityEvent onPlayerStart; //bird �����̺�Ʈ
    public UnityEvent onGameOver; // ���ӿ����Ǿ��� �� �����̺�Ʈ
    public UnityEvent onSetPlayer; //�÷��̾� �ʱ���ġ�� �̵�

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
        OnInitialize.Invoke(); //Titleȭ������ �ʱ�ȭ, bg setActive false�� �س���
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
                onStart.Invoke(); //������Ʈ ���� 1��
                ready = false;
            }
        }
        
    }

    public void ChangeGameState(int st) //���������� ����Ǿ��� �� ��� ������Ʈ�� ��ȣ �����ִ� �Լ�
    {
        state = (GameState)st;
        if (st == 0) 
        {
            onSetPlayer.Invoke();
            //�÷��̾� setActive false���ְ� ��ġ���� �̺�Ʈ
        }
        if (st == 1) //���� �÷��� state�� ����Ǿ��ٸ�,
        {
            count = 3;
            ready = true;
            
            if (start)
            {
                onSetPlayer.Invoke();
                onBGStart.Invoke(); //bg setActive true�� �ٲٱ�, scrollspeed �ֱ�
                onPlayerStart.Invoke(); //player���� �̵��Ҽ��ִٴ� ��ȣ�ֱ�
            }
            
        }
        if (st == 2) //�׾��ٸ�
        {
            Debug.Log("�׾���");
            start = false;
            score = 0;
            onGameOver.Invoke(); //���ӵ� ���̰�
            
        }
        if (st == 3) //UI �ִϸ��̼� ī��Ʈ�ٿ�
        {
            ready = true;
            onReady.Invoke();
        }
    }

    public void GetScore()
    {
        score += 1;
    }

    // Ÿ��Ʋ state : 0 --> 1 ( ��ư ������ ��)
    // �÷��� state : 1 --> 2
    // ���ӿ��� state : 2 --> 0


}
