using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ending : MonoBehaviour
{
    public static int Storycut;
    public GameObject FirstCut;
    public GameObject SecondCut;
    public GameObject ThirdCut;
    public GameObject EndingCredit;

    public GameObject Text1;
    public GameObject Text2;
    public GameObject Text3;
    public GameObject Button;
    // Start is called before the first frame update
    void Start()
    {
        Storycut = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Storycut == 0)
        {
            FirstCut.gameObject.SetActive(true);
        }
        if (Storycut == 1)
        {
            FirstCut.gameObject.SetActive(false);
            SecondCut.gameObject.SetActive(true);
        }
        if (Storycut == 2)
        {
            SecondCut.gameObject.SetActive(false);
            ThirdCut.gameObject.SetActive(true);
        }
        if(Storycut == 3)
        {
            EndingCredit.gameObject.SetActive(true);
        }
        if (Storycut == 4)
        {
            Text1.gameObject.SetActive(false);
            Text2.gameObject.SetActive(false);
            Text3.gameObject.SetActive(true);
            Button.gameObject.SetActive(true);
        }
    }
}
