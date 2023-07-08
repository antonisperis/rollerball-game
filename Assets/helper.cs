using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helper : interaction
{
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.gameObject.transform.Rotate(0, 50* Time.deltaTime, 0);
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (other.gameObject.GetComponent<interaction>().health != 5)
            {
                other.gameObject.GetComponent<interaction>().health += 1;
                Destroy(this.gameObject);
                print("current health");
                print(other.gameObject.GetComponent<interaction>().health);
            }
        }
    }
}
