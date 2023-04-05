using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointScript : MonoBehaviour
{
    public GameObject cube;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject cubeClone = Instantiate(cube) as GameObject;

            cubeClone.transform.position = transform.position;
        }
    }
}
