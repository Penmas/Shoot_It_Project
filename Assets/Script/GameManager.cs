using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public static int MyScore;
    public float StageScore;
    public Text ScoreText;
    public Text ClearScoreText;
    public Text GameOverScoreText;
    public GameObject LosePanel;
    public GameObject ClearPanel;
    public static int GameState; // 2=실패, 1=클리어, 0=진행중, -1=시작중
    public int NextGameStage;
    public int MyGameStage;

    public GameObject TimeOutImage;

    public static GameManager _instance;


    private void Awake()
    {
        if (!instance)
            instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        MyScore = 0;
        GameState = -1;
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = MyScore.ToString();
        GameOverScoreText.text = MyScore.ToString();
        ClearScoreText.text = MyScore.ToString();

        if (MyScore >= StageScore)
        {
            GameState = 1;
            Invoke("Clear", 1);
            if(MyGameStage >= GameStatus.GameStageOpen)
            {
                GameStatus.GameStageOpen = NextGameStage;
            }
        }

        if(GameState == 2)
        {
            TimeOutImage.gameObject.SetActive(true);
            Invoke("Lose", 1);
        }
    }

    public void Lose()
    {
        LosePanel.gameObject.SetActive(true);
    }
    public void Clear()
    {
        ClearPanel.gameObject.SetActive(true);
    }
}
