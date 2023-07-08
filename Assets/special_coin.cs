using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class special_coin : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Rotate(0, 0, 50 * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            collision.gameObject.GetComponent<interaction>().coins += 1;
            print("current coin");
            print(collision.gameObject.GetComponent<interaction>().coins);
           
        }
    }
   
}

