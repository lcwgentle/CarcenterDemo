using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera1 : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera cameram;
    public Camera Camerao;
    public void Jump()
    {
        cameram.transform.position = Camerao.transform.position;
        cameram.transform.rotation = Camerao.transform.rotation;

    }
}
