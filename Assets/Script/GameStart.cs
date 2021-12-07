using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    private int Timer = 0;
    public GameObject Ready;
    public GameObject Go;
    void Start()
    {
        Timer = 0;
        Ready.SetActive(false);
        Go.SetActive(false);

    }

    void Update()
    {
        //���� ���۽� ����
        if (Timer == 0)
        {
            Time.timeScale = 0.0f;
        }
        if (Timer <= 280)
        {
            Ready.SetActive(true);
            Timer++;
            if (Timer > 160)
            {
                Ready.SetActive(false);
                Go.SetActive(true);
            }
            if (Timer >= 280)
            {
                Go.SetActive(false);
                StartCoroutine(this.LoadingEnd());
                Time.timeScale = 1.0f; //���ӽ���
                GameManager.GameState = 0;
            }
        }
    }

    IEnumerator LoadingEnd()
    {
        yield return new WaitForSeconds(5.0f);
    }
}
