﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batjump : MonoBehaviour
{
    private bool batdead = false;
    // Start is called before the first frame update
    void Start()
    {
    }
    float a = 0;
    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject.transform.parent.Find("Bat").GetComponent<Collider2D>());
        gameObject.transform.parent.Find("Bat").GetComponent<Rigidbody2D>().simulated = true;
        gameObject.transform.parent.transform.eulerAngles = new Vector3(0, 0, 80.0f);
        gameObject.SetActive(false);
        
    }

}
