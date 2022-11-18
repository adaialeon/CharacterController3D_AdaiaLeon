using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunCycle : MonoBehaviour
{
    public float zAxis;
    
    void Update()
    {
        this.transform.RotateAround(Vector3.zero, Vector3.right, zAxis);
    }
}
