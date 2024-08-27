using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class button_data : MonoBehaviour
{
    // Start is called before the first frame update
    public Text timetext;
    public GameObject center;
    public bool bool2=false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void jump()
    {
        DateTime NowTime =DateTime.Now.ToLocalTime();
        timetext.text=NowTime.ToString("yyyy/MM/dd HH:mm:ss");
        if(bool2==false){
            center.SetActive(true);
            bool2=true;
        }
        else
        {
            center.SetActive(false);
            bool2=false;
        }
    }
}
