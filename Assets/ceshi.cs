using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ceshi : MonoBehaviour
{

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // �����⵽���������
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // ��������
            RaycastHit hitInfo;
            if (Physics.Raycast(ray, out hitInfo)) // ��������������ཻ
            {
                Debug.Log("Clicked on " + hitInfo.collider.gameObject.name); // �����������������Ƶ�����̨
            }
        }
    }
}

