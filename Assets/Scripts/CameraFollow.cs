using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Vector3 offset;
    Vector3 tempVec3 = new Vector3();
    public  Transform target;
   [SerializeField] float pos = 1050;

    void LateUpdate()
    {
        if (target == null) return;
        tempVec3.x = target.position.x + pos;
        tempVec3.y = this.transform.position.y;
        this.transform.position = tempVec3 + offset;
    }
}


