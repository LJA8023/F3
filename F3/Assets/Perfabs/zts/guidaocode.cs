﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guidaocode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Car"))
        {
            collision.gameObject.GetComponent<Car>().isCanMove = false;
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            Destroy(collision.gameObject.GetComponent<Collider2D>());
        }
    }
}
