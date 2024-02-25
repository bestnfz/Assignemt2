using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playershooting : MonoBehaviour
{
    [SerializeField] private GameObject m_bullet;
    [SerializeField] private Transform m_bulletSpawnPoint;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            Instantiate(m_bullet, m_bulletSpawnPoint.position, Quaternion.identity);

        }
    }
}