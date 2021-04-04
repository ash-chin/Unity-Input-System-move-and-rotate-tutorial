using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Secondaryrotation : MonoBehaviour
{
    Vector3 myvec = new Vector3(0.0f, 0.0f, -10f);
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(myvec * Time.deltaTime, Space.Self);
    }
}
