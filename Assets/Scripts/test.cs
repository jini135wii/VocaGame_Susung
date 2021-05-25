using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    Quaternion angle;
    // Start is called before the first frame update
    void Start()
    {
        angle = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, 0), 3f * Time.deltaTime);
    }
}
