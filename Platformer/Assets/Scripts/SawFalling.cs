using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawFalling : MonoBehaviour
{
    [SerializeField] private GameObject Saw;
    [SerializeField] private Collider2D GroundCollider;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Saw.SetActive(true);
            Destroy(Saw, 7);
        }
    }
    private void Update() => IgnoreGroundCollider();
    private void IgnoreGroundCollider()
    {
        if (Saw != null)
        {
            Physics2D.IgnoreCollision(Saw.GetComponent<Collider2D>(), GroundCollider);
        }
    }
}
