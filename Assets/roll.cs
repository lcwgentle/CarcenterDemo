using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class roll : MonoBehaviour
{
    // Start is called before the first frame update
    public Scrollbar Scrollbar1;
    public float speed1=0.05f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("InsSrollBar");
    }
    IEnumerator InsSrollBar()
    {
        yield return new WaitForEndOfFrame();
        if(Scrollbar1.value<1)
        {
            Scrollbar1.value = Scrollbar1.value +speed1;
        }
        else
        {
            Scrollbar1.value = -1;
        }
    }
}
