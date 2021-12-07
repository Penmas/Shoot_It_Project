using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatus : MonoBehaviour
{
    public static int GameStageOpen;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        GameStageOpen = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
