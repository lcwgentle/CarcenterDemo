using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Show : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera camera1;
    public Camera Transform1, Transform2;
   
    public bool bool1 = false;
    
    public void Jump()
    {
        if(bool1==false)
        {
            camera1.transform.position = Transform1.transform.position;
            camera1.transform.rotation = Transform1.transform.rotation;
            bool1 = true;
        }
        else if (bool1 == true)
        {
            camera1.transform.position = Transform2.transform.position;
            camera1.transform.rotation = Transform2.transform.rotation;
            Debug.Log(Transform2.transform);
            bool1 = false;
        }

    }
    
}
