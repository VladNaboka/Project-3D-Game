using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreFinishBehaviour : MonoBehaviour
{
    Vector3 offsetZ;
    void Update()
    {
        float X = Mathf.MoveTowards(transform.position.x, 0, 2f * Time.deltaTime);
        float Z = transform.position.z + 3f * Time.deltaTime;
        transform.position = new Vector3(X, 0, Z);

        float rot = Mathf.MoveTowardsAngle(transform.eulerAngles.y, 0, Time.deltaTime * 100f);
        transform.localEulerAngles = new Vector3(0, rot, 0);
        //offsetZ = transform.position + new Vector3(0, 0, 3 * Time.deltaTime);
        //transform.position = new Vector3(0, 0, offsetZ.z);
    }
}
