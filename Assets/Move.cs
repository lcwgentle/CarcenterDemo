using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speedr=1.5f;
    public float speedm=5f;
    public float z;
    private void LateUpdate()
    {
        if(Input.GetMouseButton(1))
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;

            transform.Rotate(Vector3.up, Input.GetAxis("Mouse X") * speedr, Space.World);
            transform.Rotate(Vector3.left, Input.GetAxis("Mouse Y") * speedr, Space.Self);

            if (Input.GetKey(KeyCode.Q))
                z = -1;
            else if (Input.GetKey(KeyCode.E))
                z = 1;
            else
                z = 0;

            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");
            transform.Translate(new Vector3(h, z, v) * speedm * Time.deltaTime);
        }
        else
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
