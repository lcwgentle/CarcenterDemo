using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button_weather : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject sun;
    public GameObject rain;
    public GameObject snow;
    public string weather;
    public Text weather2;
    public void jump()
    {
        sun.SetActive(true);
        rain.SetActive(false);
        snow.SetActive(false);
        weather2.text=weather;

    }
}
