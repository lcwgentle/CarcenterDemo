using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class car1 : MonoBehaviour
{
    private float h; 
    private float v; 
    public static float abc = 1f;
    private float angle;
    public WheelCollider lf,rf,lb,rb; 
    public Transform lfT,rfT,lbT,rbT;
    public float angleSpeed;
    public float speed;
    void Start()
    {
        abc = 1f;     
    }
    void Update()
    {
        
    }

    // Update is called once per frame
    public void FixedUpdate()
    {
       
        v = 1;
        angle = angleSpeed * h;
        lf.steerAngle = angle;
        rf.steerAngle = angle;
        lf.motorTorque = v * (speed*abc);
        rf.motorTorque = v * (speed*abc); 

        UpdateWheel(lfT,lf);
        UpdateWheel(rfT,rf);
        UpdateWheel(lbT,lb);
        UpdateWheel(rbT,rb);
       
    }


        
    

    void UpdateWheel(Transform trans,WheelCollider wheel)
    {
        Vector3 pos = trans.position;
        Quaternion rot = trans.rotation;
        wheel.GetWorldPose(out pos,out rot);
        trans.position = pos;
        trans.rotation = rot;
    }
}
