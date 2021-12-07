using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StageSelect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClickFirstStage()
    {
        Debug.Log("1 Stage Select");
        SceneManager.LoadScene("FirstStage", LoadSceneMode.Single);
    }
    public void OnClickSecondStage()
    {
        Debug.Log("2 Stage Select");
        SceneManager.LoadScene("SecondStage", LoadSceneMode.Single);
    }
    public void OnClickThirdStage()
    {
        Debug.Log("3 Stage Select");
        SceneManager.LoadScene("ThirdStage", LoadSceneMode.Single);
    }
    public void OnClickFourthStage()
    {
        Debug.Log("4 Stage Select");
        SceneManager.LoadScene("FourthStage", LoadSceneMode.Single);
    }
    public void OnClickLastStage()
    {
        Debug.Log("Last Stage Select");
        SceneManager.LoadScene("LastStage", LoadSceneMode.Single);
    }


}
