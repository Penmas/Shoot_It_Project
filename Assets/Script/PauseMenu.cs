using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PausePanel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickPauseON()
    {
        Debug.Log("�Ͻ�����");
        PausePanel.gameObject.SetActive(true);
        Time.timeScale = 0.0f;
        GameManager.GameState = -2;

    }
    public void OnClickPauseOFF()
    {
        Debug.Log("�Ͻ����� ����");
        PausePanel.gameObject.SetActive(false);
        Time.timeScale = 1f;
        GameManager.GameState = 0;

    }
    public void OnClickReStart()
    {
        Debug.Log("�����");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
