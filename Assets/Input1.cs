using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Input1 : MonoBehaviour
{
    // Start is called before the first frame update
    public Text text;
    public InputField InputField;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public  void OnEndEdit()
    {
        text.text=InputField.text;
    }

    
}
