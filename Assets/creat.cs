using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creat : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Transform1;
    public GameObject car;
    private float t1, t2;
    void Start()
    {
        t1 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        t2 = Time.fixedTime;
        //if(t2-t1>3)
        //Instantiate(car, transform.position, transform.rotation);
    }
}
