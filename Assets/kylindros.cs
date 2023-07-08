using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kylindros : MonoBehaviour
{

   
    private void Start()
    {
        
    }
    void Update()
    {
        this.gameObject.transform.Rotate( 0,0,200 * Time.deltaTime);
      
    }



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            
            collision.gameObject.GetComponent<interaction>().health -= 1;
            Debug.Log("current health");
            print(collision.gameObject.GetComponent<interaction>().health);
        }

    }
}