using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ceshi : MonoBehaviour
{

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 如果检测到鼠标左键点击
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // 创建射线
            RaycastHit hitInfo;
            if (Physics.Raycast(ray, out hitInfo)) // 如果光线与物体相交
            {
                Debug.Log("Clicked on " + hitInfo.collider.gameObject.name); // 输出被点击的物体名称到控制台
            }
        }
    }
}

