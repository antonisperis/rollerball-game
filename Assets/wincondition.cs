﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wincondition : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        victory();
	}
    void victory()
    {
        if(Input.GetKey("w"))
        {
            if(Input.GetKey("i"))
            {
                if(Input.GetKey("n"))
                {
#if UNITY_EDITOR
                    // Application.Quit() does not work in the editor so
                    // UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
                    UnityEditor.EditorApplication.isPlaying = false;
#else
         Application.Quit();
#endif
                }
            }
        }
    }
}
