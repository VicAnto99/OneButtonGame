using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Variables
{
    public float xMin, xMax, zMin, zMax;
}
public class Player : MonoBehaviour
{
    [Header("Movimiento")]
    public Variables var;
    private Rigidbody2D rig;
    private SpriteRenderer ren;
    public float speed;
    public float speedcon;
    public bool flipX;
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        ren = GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        rig.position = new Vector3(Mathf.Clamp(rig.position.x, var.xMin, var.xMax), Mathf.Clamp(rig.position.y, var.zMin, var.zMax), 0f);
        if (Input.GetKey(KeyCode.Space))
        {
            Vector3 mov = new Vector3(1f, 0f, 0f);
            rig.velocity = mov * speedcon;
            ren.flipX = true;
        }
        else
        {
            Vector3 mov = new Vector3(1f, 0f, 0f);
            rig.velocity = mov * speed;
            ren.flipX = false;
        }
        if (transform.position.y <= -69)
        {
            Vector3 mov = new Vector3(0f, 0f, 0f);
            rig.velocity = mov * speedcon;
        }
    }
}
