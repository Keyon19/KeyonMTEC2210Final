using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{

    public float speed = 5.0f;
    void Update()
    {
        float xMove = Input.GetAxisRaw("Horizontal");
    
        float xMovement = xMove * speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.RightShift))
        {
            transform.Translate(xMovement * 4, 0, 0);
        } else
        {
            transform.Translate(xMovement, 0, 0);

        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            Destroy(gameObject);
            SceneManager.LoadScene("mainScene");
       
        }

    }

}
