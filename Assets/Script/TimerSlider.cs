using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerSlider : MonoBehaviour
{
    Slider slTimer;
    float fSliderBarTime;
    public float TimeDown;

    // Start is called before the first frame update
    void Start()
    {
        slTimer = GetComponent<Slider>();
    }
    // Update is called once per frame
    void Update()
    {
        if(slTimer.value > 0.0f && GameManager.GameState == 0)
        {
            slTimer.value -= (Time.deltaTime / TimeDown);
        }
        
        if(slTimer.value == 0.0f)
        {
            GameManager.GameState = 2;
        }

    }

   
}
