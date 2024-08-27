using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Testclick : MonoBehaviour,IPointerClickHandler
{
    public GameObject camera1;
    public GameObject camera2;
   
    public void  OnPointerClick(PointerEventData eventData)
    {
        camera1.SetActive(false);
        camera2.SetActive(true);
        Debug.Log("1");
        if (eventData.button == PointerEventData.InputButton.Left) // 判断是否是鼠标左键点击
        {
            Debug.Log("hahahah " + eventData.pointerCurrentRaycast.gameObject.name); // 输出当前点击的GameObject的名称
        }
    }

    public void Test()
    {
        Debug.Log("123");
    }
    
}
