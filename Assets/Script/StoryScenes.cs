using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoryScenes : MonoBehaviour
{
    public GameObject FirstStory;
    public GameObject SecondStory;
    public GameObject ThirdStory;
    public static int storycut;
    // Start is called before the first frame update
    void Start()
    {
        storycut = 0;
        FirstStory.gameObject.SetActive(true);
        SecondStory.gameObject.SetActive(false);
        ThirdStory.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonUp(0))
        {
            storycut++;
        }
        if(storycut == 1)
        {
            FirstStory.gameObject.SetActive(false);
            SecondStory.gameObject.SetActive(true);
        }

        if (storycut == 2)
        {
            FirstStory.gameObject.SetActive(false);
            SecondStory.gameObject.SetActive(false);
            ThirdStory.gameObject.SetActive(true);
        }
        if (storycut == 3)
        {
            SceneManager.LoadScene("Stage", LoadSceneMode.Single);
        }
    }


    
}
