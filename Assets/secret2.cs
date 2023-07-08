using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secret2 : MonoBehaviour {


    private bool dirRight = true;
    public float speed = 4.0f;
    private float zcoo;

    private void Start()
    {
        zcoo = transform.position.z;
    }
    void Update()
    {
        if (dirRight)
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        else
            transform.Translate(-Vector3.forward * speed * Time.deltaTime);

        if (transform.position.z >= zcoo + 2.9f)
        {
            dirRight = false;
        }

        if (transform.position.z <= zcoo - 2.9f)
        {
            dirRight = true;
        }
    }



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<interaction>().health -= 1;
            print("current health");
            print(collision.gameObject.GetComponent<interaction>().health);
        }

    }

}
