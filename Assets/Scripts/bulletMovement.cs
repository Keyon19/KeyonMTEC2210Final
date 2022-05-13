using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMovement : MonoBehaviour
{

    public float speed = 5;
    void Update()
    {
        float yValue = speed * Time.deltaTime;
        transform.Translate(0, yValue, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "destroyWall")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "enemy")
        {
            Destroy(gameObject);
        }
    }
}

