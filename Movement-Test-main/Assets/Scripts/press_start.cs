using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class press_start : MonoBehaviour
{
    Button button;
    public string sceneName = "SampleScene";
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
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
}
