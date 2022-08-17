using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opponent : MonoBehaviour
{
    Rigidbody RB;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }
    void Move()
    {
        RB.velocity = new Vector3(0, 0, speed);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "destroyer")
        {
            Destroy(gameObject);
        }
    }
}
