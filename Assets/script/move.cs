using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed=1;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            transform.position += new Vector3(0,0,speed);

        if (Input.GetKey(KeyCode.DownArrow))
            transform.position -= new Vector3(0, 0, speed);


        if (Input.GetKey(KeyCode.RightArrow))
            transform.position += new Vector3(speed, 0, 0);

        if (Input.GetKey(KeyCode.LeftArrow))
            transform.position -= new Vector3(speed, 0, 0);

    }
}
