﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magicwall : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")&& (collision.gameObject.GetComponent<interaction>().coins==4))
        {
            Destroy(this.gameObject);
        }
    }
}
