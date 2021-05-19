using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMoves : MonoBehaviour
{
    public float speed = 1.0f;
    public float start_x;
    public float end_x;
    void Update()
    {
        transform.Translate(-1 * speed * Time.deltaTime, 0, 0);
        if (transform.position.x < end_x) Redo();
    }
    void Redo()
    {
        transform.Translate(-1 * (end_x - start_x), 0, 0);
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        Debug.Log(coll.gameObject.name);
    }
}
