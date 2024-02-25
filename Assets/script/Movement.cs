using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 50;
    // Start is called before the first frame update
    void Start()
    {
      
    }

     void Update()
    {

        if (Input.GetKey(KeyCode.F))
            transform.position += Vector3.forward * speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.B))
            transform.position +=  Vector3.back *speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.L))
            transform.position += Vector3.left * speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.R))
            transform.position += Vector3.right * speed * Time.deltaTime;
    }

}
