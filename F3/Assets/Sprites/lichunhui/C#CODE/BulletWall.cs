﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletWall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        /*collision.gameObject.GetComponent<Rigidbody2D>()..velocity = new Vector2(0, 0);*/
    }
}
