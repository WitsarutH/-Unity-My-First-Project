using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody rb;
    public Vector3 movement;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Jump");
        float z = Input.GetAxis("Vertical");

        movement = new Vector3(x, y, z);
    }

    private void FixedUpdate()
    {
        movePlayer(movement);
    }
    
    void movePlayer(Vector3 direction)
    {
        //rb.velocity = direction * speed;
        //rb.MovePosition(transform.position + (direction * speed * Time.deltaTime));
        rb.AddForce(direction * speed);
    }
}
