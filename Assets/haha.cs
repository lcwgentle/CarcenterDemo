using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class haha : MonoBehaviour, IPointerClickHandler
{
    public GameObject camera1;
    public GameObject camera2;

    public void OnPointerClick(PointerEventData eventData)
    {
        camera1.SetActive(false);
        camera2.SetActive(true);
        Debug.Log("Camera switched.");
    }
}