﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class togeTrigger : MonoBehaviour
{
    public int m_damage = 10;

    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.SendMessage("BeDamaged", m_damage, SendMessageOptions.DontRequireReceiver);
        }
    }
}

