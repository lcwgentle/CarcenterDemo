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
        if (eventData.button == PointerEventData.InputButton.Left) // �ж��Ƿ������������
        {
            Debug.Log("hahahah " + eventData.pointerCurrentRaycast.gameObject.name); // �����ǰ�����GameObject������
        }
    }

    public void Test()
    {
        Debug.Log("123");
    }
    
}
