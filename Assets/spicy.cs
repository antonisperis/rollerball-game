using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spicy : MonoBehaviour {

    private bool dirRight = true;
    public float speed = 9.0f;
    private float xcoo;

    private void Start()
    {
        xcoo = transform.position.x;
    }
    void Update()
    {
        if (dirRight)
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        else
            transform.Translate(-Vector2.right * speed * Time.deltaTime);

        if (transform.position.x >= xcoo + 5.0f)
        {
            dirRight = false;
        }

        if (transform.position.x <= xcoo - 5.0f)
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
