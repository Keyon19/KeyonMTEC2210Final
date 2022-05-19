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
        /*
                if (collision.gameObject.name == "enemy01(clone)")
                {
                    Destroy(gameObject);
                    scoreCounter.Instance.addPoints1();
                }

                if (collision.gameObject.name == "enemy02(clone)")
                {
                    Destroy(gameObject);
                    scoreCounter.Instance.addPoints2();
                }
                if (collision.gameObject.name == "enemy03(clone)")
                {
                    Destroy(gameObject);
                    scoreCounter.Instance.addPoints3();
                }

                if (collision.gameObject.name == "enemy04(clone)")
                {
                    Destroy(gameObject);
                    scoreCounter.Instance.addPoints4();
                }
                if (collision.gameObject.name == "enemy05(clone)")
                {
                    Destroy(gameObject);
                    scoreCounter.Instance.addPoints5();
                }

                if (collision.gameObject.name == "ufo(clone)")
                {
                    Destroy(gameObject);
                    scoreCounter.Instance.addPointsufo();
                }
        */
        
    }
}

