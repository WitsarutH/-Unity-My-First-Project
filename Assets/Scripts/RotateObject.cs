using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("left clk");
            transform.Rotate(0f, 1f * speed, 0f);
        }
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("right clk");
            transform.Rotate(0f, -1f * speed, 0f);
        }
        if (Input.GetMouseButtonDown(2))
        {
            Debug.Log("middle clk");
            transform.Rotate(-1f * speed, 0f, 0f);
        }
    }
}
