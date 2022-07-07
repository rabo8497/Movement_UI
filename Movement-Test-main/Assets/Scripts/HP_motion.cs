using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class HP_motion : MonoBehaviour
{
    private Image image;
    //PlayerMovement PlayerMovement;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        //GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    float timer = 0f;
    // Update is called once per frame
    void Update()
    {
            //timer += Time.deltaTime; 
        image.fillAmount = GameObject.Find("Player").GetComponent<PlayerMovement>()._hp/100;
    }
}
