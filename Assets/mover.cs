using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour {
    public float rightLimit = 13f;
    public float leftLimit = 13f;
    public float speed = 2.0f;
    private int direction = 1;
    Vector3 movement;
    void Update()
    {
        if (transform.position.x > rightLimit)
        {
            direction = -1;
        }
        else if (transform.position.x < leftLimit)
        {
            direction = 1;
        }
        movement = Vector3.right * direction * speed * Time.deltaTime;
        transform.Translate(movement);
    }


}
