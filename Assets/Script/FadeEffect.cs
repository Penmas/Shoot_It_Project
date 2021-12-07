using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeEffect : MonoBehaviour
{

    private Image image;
    float time = 0f;
    float F_time = 200f;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Ending.Storycut == 3)
            StartCoroutine(FadeFlow1());
    }

    IEnumerator FadeFlow1()
    {
        
        Color color = image.color;
        while(color.a > 0f)
        {
            time += Time.deltaTime / F_time;
            color.a = Mathf.Lerp(1, 0, time);
            image.color = color;
            yield return null;
        }
        image.gameObject.SetActive(true);
        yield return null;

        Ending.Storycut = 4;
    }
}
