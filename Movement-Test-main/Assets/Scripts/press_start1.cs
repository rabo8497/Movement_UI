using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class press_start1 : MonoBehaviour
{
    Button button;
    public string sceneName = "SampleScene";
    public GameObject gameObject;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        gameObject = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClickButton()
    {
        Debug.Log("로딩");
        SceneManager.LoadScene(sceneName);
    }
    public void go_setting()
    {
        gameObject.SetActive(true);
        Debug.Log("세팅");
    }
    public void go_start()
    {
        gameObject.SetActive(false);
    }
}
