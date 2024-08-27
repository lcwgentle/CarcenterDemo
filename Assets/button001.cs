using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button001 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject roll;
    public bool bool1=false;
   public void jump()
   {
        if(bool1==false)
        {
            roll.SetActive(true);
            bool1 =true;
        }
        else
        {
            roll.SetActive(false);
            bool1 =false;
        }
   }
}
