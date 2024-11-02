using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawFalling : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb2DSaw;

    private RigidbodyConstraints2D rb2DConstraints;


    private void Awake()
    {
        rb2DConstraints = rb2DSaw.constraints;   
    }


    //    var RigidbodyConstraints2D originalConstraints;

    //private void Awake()
    //    {
    //        originalConstraints = rigidbody.constraints;
    //    }

    //    private void FreezeConstraints()
    //    {
    //        rigidbody.constraints = RigidbodyConstraints.FreezePositionY;
    //    }

    //    private void UnFreezeConstraints()
    //    {
    //        rigidbody.constraints = originalConstraints;
    //    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            rb2DSaw.constraints = rb2DConstraints;
        }
    }
}
