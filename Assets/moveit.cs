using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveit : MonoBehaviour {

    // Use this for initialization
    private bool dirRight = true;
    public float speed = 10.0f;
    private float xcoo;

    private void Start()
    {
        xcoo = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (dirRight)
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        else
            transform.Translate(-Vector2.right * speed * Time.deltaTime);

        if (transform.position.x >= xcoo + 25.0f)
        {
            dirRight = false;
        }

        if (transform.position.x <= xcoo - 25.0f)
        {
            dirRight = true;
        }
    }
}
