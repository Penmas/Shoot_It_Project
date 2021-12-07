using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject OptionPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickStart()
    {
        Debug.Log("Start Story");
        SceneManager.LoadScene("StoryScenes", LoadSceneMode.Single);
    }

    public void OnClickNewStart()
    {
        Debug.Log("Stage Select Page");
        SceneManager.LoadScene("Stage",LoadSceneMode.Single);
    }

    public void OnClickOptionOn()
    {
        Debug.Log("옵션열기");
        OptionPanel.gameObject.SetActive(true);
    }
    public void OnClickOptionOff()
    {
        Debug.Log("옵션닫기");
        OptionPanel.gameObject.SetActive(false);
    }

    public void OnClickStageSelectBack()
    {
        Debug.Log("스테이지로 돌아가기");
        SceneManager.LoadScene("Stage", LoadSceneMode.Single);
    }
    public void OnClickReStart()
    {
        Debug.Log("재시작");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void OnClickNextStory()
    {
        Debug.Log("다음스토리");
        StoryScenes.storycut++;
    }

    public void OnClickEndingCredit()
    {
        Debug.Log("엔딩으로");
        SceneManager.LoadScene("EndingCredit", LoadSceneMode.Single); ;
    }
    public void OnClickNextEndingStory()
    {
        Debug.Log("다음스토리");
        Ending.Storycut++;
    }

    public void OnClickQuit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
