﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eatDiamond : MonoBehaviour
{
    public static int  Count=0 ;
    public AudioClip diamondCollect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
         if (collision.gameObject.CompareTag("Player"))
        {
           AudioSource.PlayClipAtPoint(diamondCollect, Camera.main.transform.position);
           Count++;
        }
    }
}
