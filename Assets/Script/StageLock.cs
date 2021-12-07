using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageLock : MonoBehaviour
{
    public GameObject FirstStage;
    public GameObject SecondStage;
    public GameObject ThirdStage;
    public GameObject FourthStage;
    public GameObject LastStage;

    public GameObject UnSecondStage;
    public GameObject UnThirdStage;
    public GameObject UnFourthStage;
    public GameObject UnLastStage;

    public GameObject Road1;
    public GameObject Road2;
    public GameObject Road3;
    public GameObject Road4;
    public GameObject OpenRoad2;
    public GameObject OpenRoad3;
    public GameObject OpenRoad4;
    public GameObject OpenRoad5;

    public GameObject EndingButton;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (GameStatus.GameStageOpen >= 1)
        {
            FirstStage.gameObject.SetActive(true);
        }

        if(GameStatus.GameStageOpen >= 2)
        {
            SecondStage.gameObject.SetActive(true);
            UnSecondStage.gameObject.SetActive(false);
            OpenRoad2.gameObject.SetActive(true);
            Road1.gameObject.SetActive(false);
        }

        if (GameStatus.GameStageOpen >= 3)
        {
            ThirdStage.gameObject.SetActive(true);
            UnThirdStage.gameObject.SetActive(false);
            OpenRoad3.gameObject.SetActive(true);
            Road2.gameObject.SetActive(false);
        }

        if (GameStatus.GameStageOpen >= 4)
        {
            FourthStage.gameObject.SetActive(true);
            UnFourthStage.gameObject.SetActive(false);
            OpenRoad4.gameObject.SetActive(true);
            Road3.gameObject.SetActive(false);
        }

        if (GameStatus.GameStageOpen >= 5)
        {
            LastStage.gameObject.SetActive(true);
            UnLastStage.gameObject.SetActive(false);
            OpenRoad5.gameObject.SetActive(true);
            Road4.gameObject.SetActive(false);
        }

        if (GameStatus.GameStageOpen >= 6)
        {
            EndingButton.gameObject.SetActive(true);
        }
    }
}
