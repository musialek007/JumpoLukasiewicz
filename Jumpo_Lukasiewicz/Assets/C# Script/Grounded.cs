using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour
{
    GameObject prop;
    void Start()
    {
        prop = gameObject.transform.parent.gameObject;
    }


    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "random")
        {
            prop.GetComponent<Movement>().isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "random")
        {
            prop.GetComponent<Movement>().isGrounded = false;
        }
    }
}
