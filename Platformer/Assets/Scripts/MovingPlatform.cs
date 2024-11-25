using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] private Transform _currPlatformPosition;

    private int _platformDirection = 1;


    private void FixedUpdate()
    {
        Direction();
        PlatformMove();
    }

    private void Direction()
    {
        if (_currPlatformPosition.position.x >= 240)
        {
            _platformDirection = -1;
        }
        else if (_currPlatformPosition.position.x <= 220)
        {
            _platformDirection = 1;
        }
    }
    private void PlatformMove() => _currPlatformPosition.transform.position += new Vector3(0.1f * _platformDirection, 0, 0);

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.parent = gameObject.transform;
        }
    }    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.parent = null;
        }
    }
}
