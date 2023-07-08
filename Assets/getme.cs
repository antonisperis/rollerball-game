using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getme : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.gameObject.transform.Rotate(0, 0, 50 * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<interaction>().coins += 1;
            print("current coins");
            print(other.gameObject.GetComponent<interaction>().coins);
            Destroy(this.gameObject);
        }
    }
}
