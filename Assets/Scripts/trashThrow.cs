using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trashThrow : MonoBehaviour
{
    Rigidbody2D rgd;
    // Start is called before the first frame update
    void Start()
    {
        rgd = GetComponent<Rigidbody2D>();
        transform.position = new Vector2(4, Random.Range(0.0f, 5.0f));
        rgd.velocity = new Vector2(Random.Range(-3.0f, -10.0f), 0);
    }
    void Update()
    {
        if(transform.position.y <= -1.9f)
        {
            transform.position = new Vector2(4, Random.Range(0.0f, 5.0f));
            rgd.velocity = new Vector2(Random.Range(-3.0f, -10.0f), 0);
        }
    }
}
