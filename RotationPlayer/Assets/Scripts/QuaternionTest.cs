using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaternionTest : MonoBehaviour
{
    public Transform target;
    Vector3 dirVector;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dirVector = target.position - transform.position;
       transform.rotation = Quaternion.LookRotation(dirVector);
       /* Quaternion targetRotation = Quaternion.LookRotation(dirVector);
        Quaternion currentRotation = transform.rotation;
       transform.rotation = Quaternion.Lerp(currentRotation, targetRotation, Time.deltaTime);*/
    }
}
