using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveCamera : MonoBehaviour
{
    [Header("Movimiento")]
    private Rigidbody2D rig;
    public float speed;
    public float speedcon;
    public GameObject canvas;
    public GameObject canvas2;
    void Start()
    {
        canvas.SetActive(true);
        canvas2.SetActive(false);
        rig = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (transform.position.y <= -10) {
            canvas.SetActive(false);
        }
        if (transform.position.y <= -70)
        {
            canvas2.SetActive(true);
            Vector3 mov = new Vector3(0f, 0f, 0f);
            rig.velocity = mov * speedcon;
        }

    }
}
