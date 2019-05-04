using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePiso : MonoBehaviour
{
    [Header("Movimiento")]
    private Rigidbody2D rig;
    public float speed;
    public float speedcon;
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (transform.position.x >= 7)
        {
            Vector3 mov = new Vector3(1f, 0f, 0f);
            rig.velocity = mov * speedcon;
        }
        else if(transform.position.x <= -7)
        {
            Vector3 mov = new Vector3(1f, 0f, 0f);
            rig.velocity = mov * speed;
        }
    }
}
