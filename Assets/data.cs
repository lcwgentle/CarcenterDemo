using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class data : MonoBehaviour
{
    // Start is called before the first frame update
    public Text timetext;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DateTime NowTime =DateTime.Now.ToLocalTime();
        timetext.text=NowTime.ToString("yyyy/MM/dd HH:mm:ss");
    }
}
