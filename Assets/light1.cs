using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class light1 : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider slider1;
    public GameObject gameObject1, gameObject2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (slider1.value > 135 || slider1.value < 45)
        {
            gameObject1.SetActive(true);
            gameObject2.SetActive(true);
        }
        else
        {
            gameObject1.SetActive(false);
            gameObject2.SetActive(false);
        }
            
    }
}
