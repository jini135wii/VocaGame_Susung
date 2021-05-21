using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharJump : MonoBehaviour
{
    public static int life = 3;
    public float jump = 5.0f;
    Rigidbody2D rgd2D;
    // Start is called before the first frame update
    void Start()
    {
        rgd2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) rgd2D.velocity = new Vector2(0, jump);
        if (rgd2D.angularVelocity > 100 || rgd2D.angularVelocity < -100) rgd2D.angularVelocity = 50;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0,0,0), 1.5f * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (LifeCheck.cor != (coll.name == "choiceA" ? 0 :(coll.name == "choiceB" ? 1 : 2) ) ) life--;
        Debug.Log(life);
        Debug.Log(coll.name);
        LifeCheck.nextRound();
        LifeCheck.RoundChange = true;
    }
    void OnTriggerExit2D(Collider2D coll)
    {
    }
}
