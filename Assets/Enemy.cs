using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Player m_player;
    // Start is called before the first frame update
    void Start()
    {
        m_player = FindAnyObjectByType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
      
    }
}
