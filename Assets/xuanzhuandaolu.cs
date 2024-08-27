using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xuanzhuandaolu : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform a;
    public float b,c,d;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        a.transform.Rotate(b,c,d);
    }
}
