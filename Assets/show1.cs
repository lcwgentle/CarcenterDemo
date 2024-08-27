using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class show1 : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera cameram;
    public Camera Camerar;
    public Camera Camerao;
    public bool bool1=false;
    public void  Jump()
    {
        if(bool1==false)
        {
            cameram.transform.position = Camerar.transform.position;
            cameram.transform.rotation = Camerar.transform.rotation;
            bool1 = true;
        }
        else
        {
            cameram.transform.position = Camerao.transform.position;
            cameram.transform.rotation = Camerao.transform.rotation;
            bool1 = false;
        }
        
    }
}
