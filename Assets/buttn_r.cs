using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttn_r : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera cameram;
    public Camera Camerao;
    public GameObject Z1, J2, J3, J4, J5;
    public void Jump()
    {
        cameram.transform.position = Camerao.transform.position;
        cameram.transform.rotation = Camerao.transform.rotation;
        Z1.SetActive(true);
        J2.SetActive(false);
        J3.SetActive(false);
        J4.SetActive(false);
        J5.SetActive(false);

    }
    
    
}
