using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timesilder : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider slider1;
    public GameObject lightmain;
    public Light lightmain1;
    public Material skysun,skyrain,skymorring,skynight;
    public Text weather;
    public GameObject light2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lightmain.transform.localEulerAngles=new Vector3(slider1.value,145,0);
        if(slider1.value>170||slider1.value<10)
        {
            light2.SetActive(true);
            lightmain1.intensity=0;
            RenderSettings.skybox = skynight;
            RenderSettings.ambientSkyColor=new Color(100/255f,100/255f,100/255f,1);
        }
        else if(slider1.value>135||slider1.value<45)
        {
            light2.SetActive(true);
            if(weather.text=="sun")
            {
            lightmain1.intensity=0.5f;
            RenderSettings.skybox = skymorring;
            RenderSettings.ambientSkyColor=new Color(180/255f,100/255f,60/255f,1);
            }
            else
            {
            lightmain1.intensity=0.1f;
            RenderSettings.skybox = skyrain;
            RenderSettings.ambientSkyColor=new Color(120/255f,120/255f,120/255f,1);
            }
            
        }
        else
        {
            light2.SetActive(false);
            if(weather.text=="sun")
            {
            lightmain1.intensity=0.75f;
            RenderSettings.skybox = skysun;
            RenderSettings.ambientSkyColor=new Color(200/255f,200/255f,200/255f,1);
            }
            else
            {
            lightmain1.intensity=0.1f;
            RenderSettings.skybox = skyrain;
            RenderSettings.ambientSkyColor=new Color(120/255f,120/255f,120/255f,1);
            }
            
        }
        
        
    }
}
