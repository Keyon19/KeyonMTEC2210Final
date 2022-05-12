using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public float speed = 5.0f;
    void Update()
    {
        float xMove = Input.GetAxisRaw("Horizontal");
    
        float xMovement = xMove * speed * Time.deltaTime;

        transform.Translate(xMovement, 0, 0);
    }
}
