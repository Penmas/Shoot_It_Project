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
        Debug.Log("�ɼǿ���");
        OptionPanel.gameObject.SetActive(true);
    }
    public void OnClickOptionOff()
    {
        Debug.Log("�ɼǴݱ�");
        OptionPanel.gameObject.SetActive(false);
    }

    public void OnClickStageSelectBack()
    {
        Debug.Log("���������� ���ư���");
        SceneManager.LoadScene("Stage", LoadSceneMode.Single);
    }
    public void OnClickReStart()
    {
        Debug.Log("�����");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void OnClickNextStory()
    {
        Debug.Log("�������丮");
        StoryScenes.storycut++;
    }

    public void OnClickEndingCredit()
    {
        Debug.Log("��������");
        SceneManager.LoadScene("EndingCredit", LoadSceneMode.Single); ;
    }
    public void OnClickNextEndingStory()
    {
        Debug.Log("�������丮");
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
