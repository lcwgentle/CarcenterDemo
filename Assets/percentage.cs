using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class percentage : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider slider1;
    public Text text1;
    public Text text2;
    public Text text3;

    // Update is called once per frame
    void Update()
    {
        slider1.value = float.Parse(text1.text)/float.Parse(text2.text);
        text3.text = ((int)(slider1.value*100)).ToString()+"%";
    }
}
