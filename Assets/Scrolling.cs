using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling : MonoBehaviour
{
    public float speed = 5f;
    
    void Update()
    {
        transform.position += new Vector3(-speed * Time.deltaTime, 0,0);

        if (transform.position.x < -19f)
        {
            transform.position = new Vector3(19f, transform.position.y);
        }
    }
}
