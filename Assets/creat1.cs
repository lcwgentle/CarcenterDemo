using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creat1 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject car;
    public Transform tr;
    private float t1, t2;
    void Start()
    {
        t1 = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        t2 = Time.fixedTime;
        if(t2-t1>=3)
        {
            Instantiate(car, tr.position, tr.rotation);
            t1 = t2;
        }

    }
}
