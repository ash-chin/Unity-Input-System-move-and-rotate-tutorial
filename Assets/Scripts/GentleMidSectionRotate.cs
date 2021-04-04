using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GentleMidSectionRotate : MonoBehaviour
{
    public static float rotvalue = 5;

    Vector3 rotvec = new Vector3(0, 0, rotvalue);
 
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotvec * Time.deltaTime, Space.Self);
    }
}
