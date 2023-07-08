using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endingline : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            if(other.gameObject.GetComponent<interaction>().coins==4)
            {
                print("YOU WON");

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
